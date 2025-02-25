﻿using System;
using System.Collections;
using System.Collections.Generic;
using Foundation;
using BranchXamarinSDK.iOS;
using ObjCRuntime;

namespace BranchXamarinSDK
{
	public class BranchIOS : Branch
	{
		#region Singleton

		private static BranchIOS instance = null;

		private BranchIOS () { }

		public static BranchIOS getInstance() {
			if (instance == null) {
				throw new BranchException ("You must initialize Branch before you can use the Branch object!");
			}

			return instance;
		}
			
		private IOSNativeBranch.Branch NativeBranch {
			get { return IOSNativeBranch.Branch.GetInstance(branchKey); }
		}

		#endregion

		#region Helpers declaration

		private static bool delayInitToCheckForSearchAds = false;

		private static bool useLongerWaitForAppleSearchAds = false;

		private static bool ignoreAppleSearchAdsTestData = false;

		private static bool checkPasteboardOnInstall = false;

		#endregion

		#region Initialization

		private NSDictionary launchOptions = null;

		public static void Init(String branchKey, NSDictionary launchOptions, IBranchSessionInterface callback) {
			if (instance != null) {
				return;
			}

			if (!branchKey.StartsWith("key_", StringComparison.Ordinal)) {
				Console.WriteLine ("Usage of App Key is deprecated, please move toward using a Branch key");
			}

			instance = new BranchIOS ();
			Branch.branchInstance = instance;
			instance.branchKey = branchKey;
            instance.NativeBranch.RegisterPluginName("Xamarin", "8.1.0");

            if (launchOptions != null) {
				instance.launchOptions = new NSDictionary (launchOptions);
			} else {
				instance.launchOptions = new NSDictionary ();
			}

			if (delayInitToCheckForSearchAds)
			{
				instance.NativeBranch.DelayInitToCheckForSearchAds();
			}

			if (useLongerWaitForAppleSearchAds)
			{
				instance.NativeBranch.UseLongerWaitForAppleSearchAds();
			}

			if (ignoreAppleSearchAdsTestData)
			{
				instance.NativeBranch.IgnoreAppleSearchAdsTestData();
			}

			if (checkPasteboardOnInstall)
            {
				instance.NativeBranch.CheckPasteboardOnInstall();

			}

			instance.NativeBranch.EnableLogging();

			instance.InitSession (callback);
		}

		public static void Init(String branchKey, NSDictionary launchOptions, IBranchBUOSessionInterface callback) {
			if (instance != null) {
				return;
			}

			if (!branchKey.StartsWith("key_", StringComparison.Ordinal)) {
				Console.WriteLine ("Usage of App Key is deprecated, please move toward using a Branch key");
			}

			instance = new BranchIOS ();
			Branch.branchInstance = instance;
			instance.branchKey = branchKey;

			instance.NativeBranch.RegisterPluginName("Xamarin", "8.1.0");

			if (launchOptions != null) {
				instance.launchOptions = new NSDictionary (launchOptions);
			} else {
				instance.launchOptions = new NSDictionary ();
			}

			if (EnableLogging || Runtime.Arch == Arch.SIMULATOR) {
				instance.NativeBranch.EnableLogging();
			}

			if (delayInitToCheckForSearchAds)
			{
				instance.NativeBranch.DelayInitToCheckForSearchAds();
			}

			if (useLongerWaitForAppleSearchAds)
			{
				instance.NativeBranch.UseLongerWaitForAppleSearchAds();
			}

			if (ignoreAppleSearchAdsTestData)
			{
				instance.NativeBranch.IgnoreAppleSearchAdsTestData();
			}

			if (checkPasteboardOnInstall)
			{
				instance.NativeBranch.CheckPasteboardOnInstall();

			}

			instance.NativeBranch.EnableLogging();

			instance.InitSession (callback);
		}

		#endregion


		#region Session methods

		public override void InitSession(IBranchSessionInterface callback) {
			base.InitSession (callback);
			BranchSessionListener obj = new BranchSessionListener (callback);
			callbacksList.Add (obj as Object);

			NativeBranch.InitSessionWithLaunchOptions(launchOptions, obj.InitCallback);
		}

		public override void InitSession (IBranchBUOSessionInterface callback) {
			base.InitSession (callback);
			BranchBUOSessionListener obj = new BranchBUOSessionListener (callback);
			callbacksList.Add (obj as Object);

			NativeBranch.InitSessionWithLaunchOptions(launchOptions, obj.InitCallback);
		}

		public override Dictionary<String, object> GetLastReferringParams () {
			return BranchIOSUtils.ToDictionary(NativeBranch.LatestReferringParams());
		}

		public override BranchUniversalObject GetLastReferringBranchUniversalObject () {
			return new BranchUniversalObject(BranchIOSUtils.ToDictionary (NativeBranch.LatestReferringBranchUniversalObject()));
		}

		public override BranchLinkProperties GetLastReferringBranchLinkProperties () {
			return new BranchLinkProperties(BranchIOSUtils.ToDictionary (NativeBranch.LatestReferringBranchLinkProperties()));
		}

		public override Dictionary<String, object> GetFirstReferringParams () {
			return BranchIOSUtils.ToDictionary(NativeBranch.FirstReferringParams());
		}

		public override BranchUniversalObject GetFirstReferringBranchUniversalObject () {
			return new BranchUniversalObject(BranchIOSUtils.ToDictionary (NativeBranch.FirstReferringBranchUniversalObject()));
		}

		public override BranchLinkProperties GetFirstReferringBranchLinkProperties () {
			return new BranchLinkProperties(BranchIOSUtils.ToDictionary (NativeBranch.FirstReferringBranchLinkProperties()));
		}

		#endregion


		#region Identity methods

		public override void ResetUserSession() {
			NativeBranch.ResetUserSession();
		}

		public override void SetIdentity(String user, IBranchIdentityInterface callback) {
			BranchIdentityListener obj = new BranchIdentityListener (callback);
			callbacksList.Add (obj as Object);

			NativeBranch.SetIdentity (user, obj.SetIdentityCallback);
		}

		public override void Logout(IBranchIdentityInterface callback = null) {
			BranchIdentityListener obj = new BranchIdentityListener (callback);
			callbacksList.Add (obj as Object);

			NativeBranch.LogoutWithCallback (obj.LogoutCallback);
		}

		#endregion


		#region Short Links methods

		public override void GetShortURL (IBranchUrlInterface callback,
			BranchUniversalObject universalObject,
			BranchLinkProperties linkProperties)
		{

			BranchUrlListener obj = new BranchUrlListener (callback);
			callbacksList.Add (obj as Object);

			IOSNativeBranch.BranchUniversalObject buo = BranchIOSUtils.ToNativeUniversalObject (universalObject);
			IOSNativeBranch.BranchLinkProperties blp = BranchIOSUtils.ToNativeLinkProperties (linkProperties);

			buo.GetShortUrlWithLinkProperties (blp, obj.GetShortUrlCallback);
		}

		#endregion


		#region Share Link methods

		public override void ShareLink (IBranchLinkShareInterface callback,
			BranchUniversalObject universalObject,
			BranchLinkProperties linkProperties,
			string message)
		{

			IOSNativeBranch.BranchUniversalObject buo = BranchIOSUtils.ToNativeUniversalObject (universalObject);
			IOSNativeBranch.BranchLinkProperties blp = BranchIOSUtils.ToNativeLinkProperties (linkProperties);
			UIKit.UIWindow window = UIKit.UIApplication.SharedApplication.KeyWindow;

			buo.ShowShareSheetWithLinkProperties (blp, message, window.RootViewController, delegate(string url, bool isShared) {});
		}

		#endregion


		#region Action methods

		public override void UserCompletedAction (String action, Dictionary<string, object> metadata = null) {
			NativeBranch.UserCompletedAction (action, BranchIOSUtils.ToNSDictionary (metadata));
		}

		#endregion


        #region Send Evene methods

        public override void SendEvent(BranchEvent branchEvent) {
            BranchIOSUtils.SendEvent(branchEvent);
        }

        #endregion

		#region Configuration methods

		public static void DelayInitToCheckForSearchAds()
        {
			delayInitToCheckForSearchAds = true;
		}

		public static void UseLongerWaitForAppleSearchAds()
		{
			useLongerWaitForAppleSearchAds = true;
		}

		public static void IgnoreAppleSearchAdsTestData()
		{
			ignoreAppleSearchAdsTestData = true;
		}

		public static void CheckPasteboardOnInstall()
        {
			checkPasteboardOnInstall = true;
		}

		public override void SetRetryInterval (int retryInterval) {
			NativeBranch.SetRetryInterval (retryInterval);
		}

		public override void SetMaxRetries (int maxRetries) {
			NativeBranch.SetMaxRetries ((nint)maxRetries);
		}

		public override void SetNetworkTimeout (int timeout) {
			NativeBranch.SetNetworkTimeout (timeout);
		}

		public override void RegisterView (BranchUniversalObject universalObject) {
            BranchEvent e = new BranchEvent(BranchEventType.VIEW_ITEM);
            e.AddContentItem(universalObject);
            SendEvent(e);
		}

		public override void ListOnSpotlight(BranchUniversalObject universalObject) {
			BranchIOSUtils.ToNativeUniversalObject(universalObject).ListOnSpotlight();
		}

		public override void SetRequestMetadata(string key, string value) {
			if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value)) {
                NativeBranch.SetRequestMetadataKey(key, value);
			}
		}

		public override void SetTrackingDisabled(bool value) {
			IOSNativeBranch.Branch.TrackingDisabled = value;
        }

		#endregion


		#region Handle deeplinking

		public bool ContinueUserActivity(NSUserActivity activity) {
			return NativeBranch.ContinueUserActivity(activity);
		}

		public bool OpenUrl (NSUrl url) {
			return NativeBranch.HandleDeepLink(url);
		}

		public void HandlePushNotification (NSDictionary userInfo) {
			NativeBranch.HandlePushNotification(userInfo);
		}

		#endregion
	}
}
