using System;
using Foundation;
using CoreSpotlight;
using ObjCRuntime;
using UIKit;

namespace IOSNativeBranch {

    // typedef void (^callbackWithParams)(NSDictionary * _Nullable, NSError * _Nullable);
    delegate void callbackWithParams([NullAllowed] NSDictionary arg0, [NullAllowed] NSError arg1);

    // typedef void (^callbackWithUrl)(NSString * _Nullable, NSError * _Nullable);
    delegate void callbackWithUrl([NullAllowed] string arg0, [NullAllowed] NSError arg1);

    // typedef void (^callbackWithStatus)(BOOL, NSError * _Nullable);
    delegate void callbackWithStatus(bool arg0, [NullAllowed] NSError arg1);

    // typedef void (^callbackWithList)(NSArray * _Nullable, NSError * _Nullable);
    delegate void callbackWithList([NullAllowed] NSObject[] arg0, [NullAllowed] NSError arg1);

    // typedef void (^callbackWithUrlAndSpotlightIdentifier)(NSString * _Nullable, NSString * _Nullable, NSError * _Nullable);
    delegate void callbackWithUrlAndSpotlightIdentifier([NullAllowed] string arg0, [NullAllowed] string arg1, [NullAllowed] NSError arg2);

    // typedef void (^callbackWithBranchUniversalObject)(BranchUniversalObject * _Nullable, BranchLinkProperties * _Nullable, NSError * _Nullable);
    delegate void callbackWithBranchUniversalObject([NullAllowed] BranchUniversalObject arg0, [NullAllowed] BranchLinkProperties arg1, [NullAllowed] NSError arg2);

    // @interface BNCServerResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface BNCServerResponse
    {
        // @property (nonatomic, strong) NSNumber * statusCode;
        [Export("statusCode", ArgumentSemantic.Strong)]
        NSNumber StatusCode { get; set; }

        // @property (nonatomic, strong) id data;
        [Export("data", ArgumentSemantic.Strong)]
        NSObject Data { get; set; }
    }

    // @interface BNCPreferenceHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface BNCPreferenceHelper
    {
        // @property (nonatomic, strong) NSString * lastRunBranchKey;
        [Export("lastRunBranchKey", ArgumentSemantic.Strong)]
        string LastRunBranchKey { get; set; }

        // @property (nonatomic, strong) NSDate * lastStrongMatchDate;
        [Export("lastStrongMatchDate", ArgumentSemantic.Strong)]
        NSDate LastStrongMatchDate { get; set; }

        // @property (nonatomic, strong) NSString * appVersion;
        [Export("appVersion", ArgumentSemantic.Strong)]
        string AppVersion { get; set; }

        // @property (nonatomic, strong) NSString * deviceFingerprintID;
        [Export("deviceFingerprintID", ArgumentSemantic.Strong)]
        string DeviceFingerprintID { get; set; }

        // @property (nonatomic, strong) NSString * sessionID;
        [Export("sessionID", ArgumentSemantic.Strong)]
        string SessionID { get; set; }

        // @property (nonatomic, strong) NSString * identityID;
        [Export("identityID", ArgumentSemantic.Strong)]
        string IdentityID { get; set; }

        // @property (nonatomic, strong) NSString * linkClickIdentifier;
        [Export("linkClickIdentifier", ArgumentSemantic.Strong)]
        string LinkClickIdentifier { get; set; }

        // @property (nonatomic, strong) NSString * spotlightIdentifier;
        [Export("spotlightIdentifier", ArgumentSemantic.Strong)]
        string SpotlightIdentifier { get; set; }

        // @property (atomic, strong) NSString * universalLinkUrl;
        [Export("universalLinkUrl", ArgumentSemantic.Strong)]
        string UniversalLinkUrl { get; set; }

        // @property (nonatomic, strong) NSString * userUrl;
        [Export("userUrl", ArgumentSemantic.Strong)]
        string UserUrl { get; set; }

        // @property (nonatomic, strong) NSString * userIdentity;
        [Export("userIdentity", ArgumentSemantic.Strong)]
        string UserIdentity { get; set; }

        // @property (nonatomic, strong) NSString * sessionParams;
        [Export("sessionParams", ArgumentSemantic.Strong)]
        string SessionParams { get; set; }

        // @property (nonatomic, strong) NSString * installParams;
        [Export("installParams", ArgumentSemantic.Strong)]
        string InstallParams { get; set; }

        // @property (assign, nonatomic) BOOL isDebug;
        [Export("isDebug")]
        bool IsDebug { get; set; }

        // @property (assign, nonatomic) BOOL checkedFacebookAppLinks;
        [Export("checkedFacebookAppLinks")]
        bool CheckedFacebookAppLinks { get; set; }

        // @property (assign, nonatomic) BOOL checkedAppleSearchAdAttribution;
        [Export("checkedAppleSearchAdAttribution")]
        bool CheckedAppleSearchAdAttribution { get; set; }

        // @property (assign, nonatomic) NSInteger retryCount;
        [Export("retryCount")]
        nint RetryCount { get; set; }

        // @property (assign, nonatomic) NSTimeInterval retryInterval;
        [Export("retryInterval")]
        double RetryInterval { get; set; }

        // @property (assign, nonatomic) NSTimeInterval timeout;
        [Export("timeout")]
        double Timeout { get; set; }

        // @property (atomic, strong) NSString * externalIntentURI;
        [Export("externalIntentURI", ArgumentSemantic.Strong)]
        string ExternalIntentURI { get; set; }

        // @property (nonatomic, strong) NSMutableDictionary * savedAnalyticsData;
        [Export("savedAnalyticsData", ArgumentSemantic.Strong)]
        NSMutableDictionary SavedAnalyticsData { get; set; }

        // @property (nonatomic, strong) NSDictionary * appleSearchAdDetails;
        [Export("appleSearchAdDetails", ArgumentSemantic.Strong)]
        NSDictionary AppleSearchAdDetails { get; set; }

        // @property (assign, nonatomic) BOOL appleSearchAdNeedsSend;
        [Export("appleSearchAdNeedsSend")]
        bool AppleSearchAdNeedsSend { get; set; }

        // @property (nonatomic, strong) NSString * lastSystemBuildVersion;
        [Export("lastSystemBuildVersion", ArgumentSemantic.Strong)]
        string LastSystemBuildVersion { get; set; }

        // @property (nonatomic, strong) NSString * browserUserAgentString;
        [Export("browserUserAgentString", ArgumentSemantic.Strong)]
        string BrowserUserAgentString { get; set; }

        // @property (atomic, strong) NSString * referringURL;
        [Export("referringURL", ArgumentSemantic.Strong)]
        string ReferringURL { get; set; }

        // @property (atomic, strong) NSString * branchAPIURL;
        [Export("branchAPIURL", ArgumentSemantic.Strong)]
        string BranchAPIURL { get; set; }

        // @property (readwrite, nonatomic, strong) NSString * branchBlacklistURL;
        [Export("branchBlacklistURL", ArgumentSemantic.Strong)]
        string BranchBlacklistURL { get; set; }

        // @property (assign, atomic) BOOL limitFacebookTracking;
        [Export("limitFacebookTracking")]
        bool LimitFacebookTracking { get; set; }

        // @property (atomic, strong) NSDate * previousAppBuildDate;
        [Export("previousAppBuildDate", ArgumentSemantic.Strong)]
        NSDate PreviousAppBuildDate { get; set; }

        // @property (readwrite, nonatomic, strong) NSURL * faceBookAppLink;
        [Export("faceBookAppLink", ArgumentSemantic.Strong)]
        NSUrl FaceBookAppLink { get; set; }

        // @property (atomic, strong) NSArray<NSString *> * URLBlackList;
        [Export("URLBlackList", ArgumentSemantic.Strong)]
        string[] URLBlackList { get; set; }

        // @property (assign, atomic) NSInteger URLBlackListVersion;
        [Export("URLBlackListVersion")]
        nint URLBlackListVersion { get; set; }

        // @property (assign, atomic) BOOL blacklistURLOpen;
        [Export("blacklistURLOpen")]
        bool BlacklistURLOpen { get; set; }

        // @property (assign, atomic) BOOL trackingDisabled;
        [Export("trackingDisabled")]
        bool TrackingDisabled { get; set; }

        // -(void)clearTrackingInformation;
        [Export("clearTrackingInformation")]
        void ClearTrackingInformation();

        // +(BNCPreferenceHelper *)preferenceHelper;
        [Static]
        [Export("preferenceHelper")]
        //[Verify(MethodToProperty)]
        BNCPreferenceHelper PreferenceHelper { get; }

        // -(NSString *)getAPIBaseURL;
        [Export("getAPIBaseURL")]
        //[Verify(MethodToProperty)]
        string APIBaseURL { get; }

        // -(NSString *)getAPIURL:(NSString *)endpoint;
        [Export("getAPIURL:")]
        string GetAPIURL(string endpoint);

        // -(NSString *)getEndpointFromURL:(NSString *)url;
        [Export("getEndpointFromURL:")]
        string GetEndpointFromURL(string url);

        // -(id)getBranchUniversalLinkDomains;
        [Export("getBranchUniversalLinkDomains")]
        //[Verify(MethodToProperty)]
        NSObject BranchUniversalLinkDomains { get; }

        // -(void)setRequestMetadataKey:(NSString *)key value:(NSObject *)value;
        [Export("setRequestMetadataKey:value:")]
        void SetRequestMetadataKey(string key, NSObject value);

        // -(NSMutableDictionary *)requestMetadataDictionary;
        [Export("requestMetadataDictionary")]
        //[Verify(MethodToProperty)]
        NSMutableDictionary RequestMetadataDictionary { get; }

        // -(void)addInstrumentationDictionaryKey:(NSString *)key value:(NSString *)value;
        [Export("addInstrumentationDictionaryKey:value:")]
        void AddInstrumentationDictionaryKey(string key, string value);

        // -(NSMutableDictionary *)instrumentationDictionary;
        [Export("instrumentationDictionary")]
        //[Verify(MethodToProperty)]
        NSMutableDictionary InstrumentationDictionary { get; }

        // -(void)clearInstrumentationDictionary;
        [Export("clearInstrumentationDictionary")]
        void ClearInstrumentationDictionary();

        // -(void)saveBranchAnalyticsData:(NSDictionary *)analyticsData;
        [Export("saveBranchAnalyticsData:")]
        void SaveBranchAnalyticsData(NSDictionary analyticsData);

        // -(void)clearBranchAnalyticsData;
        [Export("clearBranchAnalyticsData")]
        void ClearBranchAnalyticsData();

        // -(NSMutableDictionary *)getBranchAnalyticsData;
        [Export("getBranchAnalyticsData")]
        //[Verify(MethodToProperty)]
        NSMutableDictionary BranchAnalyticsData { get; }

        // -(NSDictionary *)getContentAnalyticsManifest;
        [Export("getContentAnalyticsManifest")]
        //[Verify(MethodToProperty)]
        NSDictionary ContentAnalyticsManifest { get; }

        // -(void)saveContentAnalyticsManifest:(NSDictionary *)cdManifest;
        [Export("saveContentAnalyticsManifest:")]
        void SaveContentAnalyticsManifest(NSDictionary cdManifest);

        // -(NSMutableString *)sanitizedMutableBaseURL:(NSString *)baseUrl;
        [Export("sanitizedMutableBaseURL:")]
        NSMutableString SanitizedMutableBaseURL(string baseUrl);

        // -(void)synchronize;
        [Export("synchronize")]
        void Synchronize();

        // +(void)clearAll;
        [Static]
        [Export("clearAll")]
        void ClearAll();
    }

    //// @protocol BNCNetworkOperationProtocol <NSObject>
    ///*
    //  Check whether adding [Model] to this declaration is appropriate.
    //  [Model] is used to generate a C# class that implements this protocol,
    //  and might be useful for protocols that consumers are supposed to implement,
    //  since consumers can subclass the generated class instead of implementing
    //  the generated interface. If consumers are not supposed to implement this
    //  protocol, then [Model] is redundant and will generate code that will never
    //  be used.
    //*/
    //[Protocol]
    //[BaseType(typeof(NSObject))]
    //interface BNCNetworkOperationProtocol
    //{
    //    // @required @property (readonly, copy) NSURLRequest * request;
    //    [Abstract]
    //    [Export("request", ArgumentSemantic.Copy)]
    //    NSUrlRequest Request { get; }

    //    // @required @property (readonly, copy) NSHTTPURLResponse * response;
    //    [Abstract]
    //    [Export("response", ArgumentSemantic.Copy)]
    //    NSHttpUrlResponse Response { get; }

    //    // @required @property (readonly, strong) NSData * responseData;
    //    [Abstract]
    //    [Export("responseData", ArgumentSemantic.Strong)]
    //    NSData ResponseData { get; }

    //    // @required @property (readonly, copy) NSError * error;
    //    [Abstract]
    //    [Export("error", ArgumentSemantic.Copy)]
    //    NSError Error { get; }

    //    // @required @property (readonly, copy) NSDate * startDate;
    //    [Abstract]
    //    [Export("startDate", ArgumentSemantic.Copy)]
    //    NSDate StartDate { get; }

    //    // @required @property (readonly, copy) NSDate * timeoutDate;
    //    [Abstract]
    //    [Export("timeoutDate", ArgumentSemantic.Copy)]
    //    NSDate TimeoutDate { get; }

    //    // @required @property (strong) NSDictionary * userInfo;
    //    [Abstract]
    //    [Export("userInfo", ArgumentSemantic.Strong)]
    //    NSDictionary UserInfo { get; set; }

    //    // @required -(void)start;
    //    [Abstract]
    //    [Export("start")]
    //    void Start();

    //    // @optional -(void)cancel;
    //    [Export("cancel")]
    //    void Cancel();
    //}

    //// @protocol BNCNetworkServiceProtocol <NSObject>
    ///*
    //  Check whether adding [Model] to this declaration is appropriate.
    //  [Model] is used to generate a C# class that implements this protocol,
    //  and might be useful for protocols that consumers are supposed to implement,
    //  since consumers can subclass the generated class instead of implementing
    //  the generated interface. If consumers are not supposed to implement this
    //  protocol, then [Model] is redundant and will generate code that will never
    //  be used.
    //*/
    //[Protocol]
    //[BaseType(typeof(NSObject))]
    //interface BNCNetworkServiceProtocol
    //{
    //    // @required +(id<BNCNetworkServiceProtocol>)new;
    //    [Static, Abstract]
    //    [Export("new")]
    //    //[Verify(MethodToProperty)]
    //    BNCNetworkServiceProtocol New { get; }

    //    // @optional -(void)cancelAllOperations;
    //    [Export("cancelAllOperations")]
    //    void CancelAllOperations();

    //    // @required -(id<BNCNetworkOperationProtocol>)networkOperationWithURLRequest:(NSMutableURLRequest *)request completion:(void (^)(id<BNCNetworkOperationProtocol>))completion;
    //    [Abstract]
    //    [Export("networkOperationWithURLRequest:completion:")]
    //    BNCNetworkOperationProtocol NetworkOperationWithURLRequest(NSMutableUrlRequest request, Action<BNCNetworkOperationProtocol> completion);

    //    // @required @property (strong) NSDictionary * userInfo;
    //    [Abstract]
    //    [Export("userInfo", ArgumentSemantic.Strong)]
    //    NSDictionary UserInfo { get; set; }

    //    // @optional -(NSError *)pinSessionToPublicSecKeyRefs:(NSArray *)publicKeys;
    //    [Export("pinSessionToPublicSecKeyRefs:")]
    //    //[Verify(StronglyTypedNSArray)]
    //    NSError PinSessionToPublicSecKeyRefs(NSObject[] publicKeys);
    //}

    // typedef void (^BNCServerCallback)(BNCServerResponse *, NSError *);
    delegate void BNCServerCallback(BNCServerResponse arg0, NSError arg1);

    // @interface BNCServerInterface : NSObject
    [BaseType(typeof(NSObject))]
    interface BNCServerInterface
    {
        // -(void)getRequest:(NSDictionary *)params url:(NSString *)url key:(NSString *)key callback:(BNCServerCallback)callback;
        [Export("getRequest:url:key:callback:")]
        void GetRequest(NSDictionary @params, string url, string key, BNCServerCallback callback);

        // -(BNCServerResponse *)postRequestSynchronous:(NSDictionary *)post url:(NSString *)url key:(NSString *)key;
        [Export("postRequestSynchronous:url:key:")]
        BNCServerResponse PostRequestSynchronous(NSDictionary post, string url, string key);

        // -(void)postRequest:(NSDictionary *)post url:(NSString *)url key:(NSString *)key callback:(BNCServerCallback)callback;
        [Export("postRequest:url:key:callback:")]
        void PostRequest(NSDictionary post, string url, string key, BNCServerCallback callback);

        //// -(void)genericHTTPRequest:(NSURLRequest *)request retryNumber:(NSInteger)retryNumber callback:(BNCServerCallback)callback retryHandler:(NSURLRequest *(^)(NSInteger))retryHandler;
        //[Export("genericHTTPRequest:retryNumber:callback:retryHandler:")]
        //void GenericHTTPRequest(NSUrlRequest request, nint retryNumber, BNCServerCallback callback, Func<nint, NSURLRequest> retryHandler);

        // @property (nonatomic, strong) BNCPreferenceHelper * preferenceHelper;
        [Export("preferenceHelper", ArgumentSemantic.Strong)]
        BNCPreferenceHelper PreferenceHelper { get; set; }
    }

    // @interface BNCServerRequest : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface BNCServerRequest : INSSecureCoding
    {
        // -(void)makeRequest:(BNCServerInterface *)serverInterface key:(NSString *)key callback:(BNCServerCallback)callback;
        [Export("makeRequest:key:callback:")]
        void MakeRequest(BNCServerInterface serverInterface, string key, BNCServerCallback callback);

        // -(void)processResponse:(BNCServerResponse *)response error:(NSError *)error;
        [Export("processResponse:error:")]
        void ProcessResponse(BNCServerResponse response, NSError error);

        // -(void)safeSetValue:(NSObject *)value forKey:(NSString *)key onDict:(NSMutableDictionary *)dict;
        [Export("safeSetValue:forKey:onDict:")]
        void SafeSetValue(NSObject value, string key, NSMutableDictionary dict);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern BNCProductCategory _Nonnull BNCProductCategoryAnimalSupplies;
        [Field("BNCProductCategoryAnimalSupplies", "__Internal")]
        NSString BNCProductCategoryAnimalSupplies { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryApparel;
        [Field("BNCProductCategoryApparel", "__Internal")]
        NSString BNCProductCategoryApparel { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryArtsEntertainment;
        [Field("BNCProductCategoryArtsEntertainment", "__Internal")]
        NSString BNCProductCategoryArtsEntertainment { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryBabyToddler;
        [Field("BNCProductCategoryBabyToddler", "__Internal")]
        NSString BNCProductCategoryBabyToddler { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryBusinessIndustrial;
        [Field("BNCProductCategoryBusinessIndustrial", "__Internal")]
        NSString BNCProductCategoryBusinessIndustrial { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryCamerasOptics;
        [Field("BNCProductCategoryCamerasOptics", "__Internal")]
        NSString BNCProductCategoryCamerasOptics { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryElectronics;
        [Field("BNCProductCategoryElectronics", "__Internal")]
        NSString BNCProductCategoryElectronics { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryFoodBeverageTobacco;
        [Field("BNCProductCategoryFoodBeverageTobacco", "__Internal")]
        NSString BNCProductCategoryFoodBeverageTobacco { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryFurniture;
        [Field("BNCProductCategoryFurniture", "__Internal")]
        NSString BNCProductCategoryFurniture { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryHardware;
        [Field("BNCProductCategoryHardware", "__Internal")]
        NSString BNCProductCategoryHardware { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryHealthBeauty;
        [Field("BNCProductCategoryHealthBeauty", "__Internal")]
        NSString BNCProductCategoryHealthBeauty { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryHomeGarden;
        [Field("BNCProductCategoryHomeGarden", "__Internal")]
        NSString BNCProductCategoryHomeGarden { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryLuggageBags;
        [Field("BNCProductCategoryLuggageBags", "__Internal")]
        NSString BNCProductCategoryLuggageBags { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryMature;
        [Field("BNCProductCategoryMature", "__Internal")]
        NSString BNCProductCategoryMature { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryMedia;
        [Field("BNCProductCategoryMedia", "__Internal")]
        NSString BNCProductCategoryMedia { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryOfficeSupplies;
        [Field("BNCProductCategoryOfficeSupplies", "__Internal")]
        NSString BNCProductCategoryOfficeSupplies { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryReligious;
        [Field("BNCProductCategoryReligious", "__Internal")]
        NSString BNCProductCategoryReligious { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategorySoftware;
        [Field("BNCProductCategorySoftware", "__Internal")]
        NSString BNCProductCategorySoftware { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategorySportingGoods;
        [Field("BNCProductCategorySportingGoods", "__Internal")]
        NSString BNCProductCategorySportingGoods { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryToysGames;
        [Field("BNCProductCategoryToysGames", "__Internal")]
        NSString BNCProductCategoryToysGames { get; }

        // extern BNCProductCategory _Nonnull BNCProductCategoryVehiclesParts;
        [Field("BNCProductCategoryVehiclesParts", "__Internal")]
        NSString BNCProductCategoryVehiclesParts { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyAED;
        [Field("BNCCurrencyAED", "__Internal")]
        NSString BNCCurrencyAED { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyAFN;
        [Field("BNCCurrencyAFN", "__Internal")]
        NSString BNCCurrencyAFN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyALL;
        [Field("BNCCurrencyALL", "__Internal")]
        NSString BNCCurrencyALL { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyAMD;
        [Field("BNCCurrencyAMD", "__Internal")]
        NSString BNCCurrencyAMD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyANG;
        [Field("BNCCurrencyANG", "__Internal")]
        NSString BNCCurrencyANG { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyAOA;
        [Field("BNCCurrencyAOA", "__Internal")]
        NSString BNCCurrencyAOA { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyARS;
        [Field("BNCCurrencyARS", "__Internal")]
        NSString BNCCurrencyARS { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyAUD;
        [Field("BNCCurrencyAUD", "__Internal")]
        NSString BNCCurrencyAUD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyAWG;
        [Field("BNCCurrencyAWG", "__Internal")]
        NSString BNCCurrencyAWG { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyAZN;
        [Field("BNCCurrencyAZN", "__Internal")]
        NSString BNCCurrencyAZN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBAM;
        [Field("BNCCurrencyBAM", "__Internal")]
        NSString BNCCurrencyBAM { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBBD;
        [Field("BNCCurrencyBBD", "__Internal")]
        NSString BNCCurrencyBBD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBDT;
        [Field("BNCCurrencyBDT", "__Internal")]
        NSString BNCCurrencyBDT { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBGN;
        [Field("BNCCurrencyBGN", "__Internal")]
        NSString BNCCurrencyBGN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBHD;
        [Field("BNCCurrencyBHD", "__Internal")]
        NSString BNCCurrencyBHD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBIF;
        [Field("BNCCurrencyBIF", "__Internal")]
        NSString BNCCurrencyBIF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBMD;
        [Field("BNCCurrencyBMD", "__Internal")]
        NSString BNCCurrencyBMD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBND;
        [Field("BNCCurrencyBND", "__Internal")]
        NSString BNCCurrencyBND { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBOB;
        [Field("BNCCurrencyBOB", "__Internal")]
        NSString BNCCurrencyBOB { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBOV;
        [Field("BNCCurrencyBOV", "__Internal")]
        NSString BNCCurrencyBOV { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBRL;
        [Field("BNCCurrencyBRL", "__Internal")]
        NSString BNCCurrencyBRL { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBSD;
        [Field("BNCCurrencyBSD", "__Internal")]
        NSString BNCCurrencyBSD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBTN;
        [Field("BNCCurrencyBTN", "__Internal")]
        NSString BNCCurrencyBTN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBWP;
        [Field("BNCCurrencyBWP", "__Internal")]
        NSString BNCCurrencyBWP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBYN;
        [Field("BNCCurrencyBYN", "__Internal")]
        NSString BNCCurrencyBYN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBYR;
        [Field("BNCCurrencyBYR", "__Internal")]
        NSString BNCCurrencyBYR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyBZD;
        [Field("BNCCurrencyBZD", "__Internal")]
        NSString BNCCurrencyBZD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCAD;
        [Field("BNCCurrencyCAD", "__Internal")]
        NSString BNCCurrencyCAD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCDF;
        [Field("BNCCurrencyCDF", "__Internal")]
        NSString BNCCurrencyCDF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCHE;
        [Field("BNCCurrencyCHE", "__Internal")]
        NSString BNCCurrencyCHE { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCHF;
        [Field("BNCCurrencyCHF", "__Internal")]
        NSString BNCCurrencyCHF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCHW;
        [Field("BNCCurrencyCHW", "__Internal")]
        NSString BNCCurrencyCHW { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCLF;
        [Field("BNCCurrencyCLF", "__Internal")]
        NSString BNCCurrencyCLF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCLP;
        [Field("BNCCurrencyCLP", "__Internal")]
        NSString BNCCurrencyCLP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCNY;
        [Field("BNCCurrencyCNY", "__Internal")]
        NSString BNCCurrencyCNY { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCOP;
        [Field("BNCCurrencyCOP", "__Internal")]
        NSString BNCCurrencyCOP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCOU;
        [Field("BNCCurrencyCOU", "__Internal")]
        NSString BNCCurrencyCOU { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCRC;
        [Field("BNCCurrencyCRC", "__Internal")]
        NSString BNCCurrencyCRC { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCUC;
        [Field("BNCCurrencyCUC", "__Internal")]
        NSString BNCCurrencyCUC { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCUP;
        [Field("BNCCurrencyCUP", "__Internal")]
        NSString BNCCurrencyCUP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCVE;
        [Field("BNCCurrencyCVE", "__Internal")]
        NSString BNCCurrencyCVE { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyCZK;
        [Field("BNCCurrencyCZK", "__Internal")]
        NSString BNCCurrencyCZK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyDJF;
        [Field("BNCCurrencyDJF", "__Internal")]
        NSString BNCCurrencyDJF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyDKK;
        [Field("BNCCurrencyDKK", "__Internal")]
        NSString BNCCurrencyDKK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyDOP;
        [Field("BNCCurrencyDOP", "__Internal")]
        NSString BNCCurrencyDOP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyDZD;
        [Field("BNCCurrencyDZD", "__Internal")]
        NSString BNCCurrencyDZD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyEGP;
        [Field("BNCCurrencyEGP", "__Internal")]
        NSString BNCCurrencyEGP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyERN;
        [Field("BNCCurrencyERN", "__Internal")]
        NSString BNCCurrencyERN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyETB;
        [Field("BNCCurrencyETB", "__Internal")]
        NSString BNCCurrencyETB { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyEUR;
        [Field("BNCCurrencyEUR", "__Internal")]
        NSString BNCCurrencyEUR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyFJD;
        [Field("BNCCurrencyFJD", "__Internal")]
        NSString BNCCurrencyFJD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyFKP;
        [Field("BNCCurrencyFKP", "__Internal")]
        NSString BNCCurrencyFKP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyGBP;
        [Field("BNCCurrencyGBP", "__Internal")]
        NSString BNCCurrencyGBP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyGEL;
        [Field("BNCCurrencyGEL", "__Internal")]
        NSString BNCCurrencyGEL { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyGHS;
        [Field("BNCCurrencyGHS", "__Internal")]
        NSString BNCCurrencyGHS { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyGIP;
        [Field("BNCCurrencyGIP", "__Internal")]
        NSString BNCCurrencyGIP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyGMD;
        [Field("BNCCurrencyGMD", "__Internal")]
        NSString BNCCurrencyGMD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyGNF;
        [Field("BNCCurrencyGNF", "__Internal")]
        NSString BNCCurrencyGNF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyGTQ;
        [Field("BNCCurrencyGTQ", "__Internal")]
        NSString BNCCurrencyGTQ { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyGYD;
        [Field("BNCCurrencyGYD", "__Internal")]
        NSString BNCCurrencyGYD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyHKD;
        [Field("BNCCurrencyHKD", "__Internal")]
        NSString BNCCurrencyHKD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyHNL;
        [Field("BNCCurrencyHNL", "__Internal")]
        NSString BNCCurrencyHNL { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyHRK;
        [Field("BNCCurrencyHRK", "__Internal")]
        NSString BNCCurrencyHRK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyHTG;
        [Field("BNCCurrencyHTG", "__Internal")]
        NSString BNCCurrencyHTG { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyHUF;
        [Field("BNCCurrencyHUF", "__Internal")]
        NSString BNCCurrencyHUF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyIDR;
        [Field("BNCCurrencyIDR", "__Internal")]
        NSString BNCCurrencyIDR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyILS;
        [Field("BNCCurrencyILS", "__Internal")]
        NSString BNCCurrencyILS { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyINR;
        [Field("BNCCurrencyINR", "__Internal")]
        NSString BNCCurrencyINR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyIQD;
        [Field("BNCCurrencyIQD", "__Internal")]
        NSString BNCCurrencyIQD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyIRR;
        [Field("BNCCurrencyIRR", "__Internal")]
        NSString BNCCurrencyIRR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyISK;
        [Field("BNCCurrencyISK", "__Internal")]
        NSString BNCCurrencyISK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyJMD;
        [Field("BNCCurrencyJMD", "__Internal")]
        NSString BNCCurrencyJMD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyJOD;
        [Field("BNCCurrencyJOD", "__Internal")]
        NSString BNCCurrencyJOD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyJPY;
        [Field("BNCCurrencyJPY", "__Internal")]
        NSString BNCCurrencyJPY { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyKES;
        [Field("BNCCurrencyKES", "__Internal")]
        NSString BNCCurrencyKES { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyKGS;
        [Field("BNCCurrencyKGS", "__Internal")]
        NSString BNCCurrencyKGS { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyKHR;
        [Field("BNCCurrencyKHR", "__Internal")]
        NSString BNCCurrencyKHR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyKMF;
        [Field("BNCCurrencyKMF", "__Internal")]
        NSString BNCCurrencyKMF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyKPW;
        [Field("BNCCurrencyKPW", "__Internal")]
        NSString BNCCurrencyKPW { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyKRW;
        [Field("BNCCurrencyKRW", "__Internal")]
        NSString BNCCurrencyKRW { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyKWD;
        [Field("BNCCurrencyKWD", "__Internal")]
        NSString BNCCurrencyKWD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyKYD;
        [Field("BNCCurrencyKYD", "__Internal")]
        NSString BNCCurrencyKYD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyKZT;
        [Field("BNCCurrencyKZT", "__Internal")]
        NSString BNCCurrencyKZT { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyLAK;
        [Field("BNCCurrencyLAK", "__Internal")]
        NSString BNCCurrencyLAK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyLBP;
        [Field("BNCCurrencyLBP", "__Internal")]
        NSString BNCCurrencyLBP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyLKR;
        [Field("BNCCurrencyLKR", "__Internal")]
        NSString BNCCurrencyLKR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyLRD;
        [Field("BNCCurrencyLRD", "__Internal")]
        NSString BNCCurrencyLRD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyLSL;
        [Field("BNCCurrencyLSL", "__Internal")]
        NSString BNCCurrencyLSL { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyLYD;
        [Field("BNCCurrencyLYD", "__Internal")]
        NSString BNCCurrencyLYD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMAD;
        [Field("BNCCurrencyMAD", "__Internal")]
        NSString BNCCurrencyMAD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMDL;
        [Field("BNCCurrencyMDL", "__Internal")]
        NSString BNCCurrencyMDL { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMGA;
        [Field("BNCCurrencyMGA", "__Internal")]
        NSString BNCCurrencyMGA { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMKD;
        [Field("BNCCurrencyMKD", "__Internal")]
        NSString BNCCurrencyMKD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMMK;
        [Field("BNCCurrencyMMK", "__Internal")]
        NSString BNCCurrencyMMK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMNT;
        [Field("BNCCurrencyMNT", "__Internal")]
        NSString BNCCurrencyMNT { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMOP;
        [Field("BNCCurrencyMOP", "__Internal")]
        NSString BNCCurrencyMOP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMRO;
        [Field("BNCCurrencyMRO", "__Internal")]
        NSString BNCCurrencyMRO { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMUR;
        [Field("BNCCurrencyMUR", "__Internal")]
        NSString BNCCurrencyMUR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMVR;
        [Field("BNCCurrencyMVR", "__Internal")]
        NSString BNCCurrencyMVR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMWK;
        [Field("BNCCurrencyMWK", "__Internal")]
        NSString BNCCurrencyMWK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMXN;
        [Field("BNCCurrencyMXN", "__Internal")]
        NSString BNCCurrencyMXN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMXV;
        [Field("BNCCurrencyMXV", "__Internal")]
        NSString BNCCurrencyMXV { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMYR;
        [Field("BNCCurrencyMYR", "__Internal")]
        NSString BNCCurrencyMYR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyMZN;
        [Field("BNCCurrencyMZN", "__Internal")]
        NSString BNCCurrencyMZN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyNAD;
        [Field("BNCCurrencyNAD", "__Internal")]
        NSString BNCCurrencyNAD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyNGN;
        [Field("BNCCurrencyNGN", "__Internal")]
        NSString BNCCurrencyNGN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyNIO;
        [Field("BNCCurrencyNIO", "__Internal")]
        NSString BNCCurrencyNIO { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyNOK;
        [Field("BNCCurrencyNOK", "__Internal")]
        NSString BNCCurrencyNOK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyNPR;
        [Field("BNCCurrencyNPR", "__Internal")]
        NSString BNCCurrencyNPR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyNZD;
        [Field("BNCCurrencyNZD", "__Internal")]
        NSString BNCCurrencyNZD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyOMR;
        [Field("BNCCurrencyOMR", "__Internal")]
        NSString BNCCurrencyOMR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyPAB;
        [Field("BNCCurrencyPAB", "__Internal")]
        NSString BNCCurrencyPAB { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyPEN;
        [Field("BNCCurrencyPEN", "__Internal")]
        NSString BNCCurrencyPEN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyPGK;
        [Field("BNCCurrencyPGK", "__Internal")]
        NSString BNCCurrencyPGK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyPHP;
        [Field("BNCCurrencyPHP", "__Internal")]
        NSString BNCCurrencyPHP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyPKR;
        [Field("BNCCurrencyPKR", "__Internal")]
        NSString BNCCurrencyPKR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyPLN;
        [Field("BNCCurrencyPLN", "__Internal")]
        NSString BNCCurrencyPLN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyPYG;
        [Field("BNCCurrencyPYG", "__Internal")]
        NSString BNCCurrencyPYG { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyQAR;
        [Field("BNCCurrencyQAR", "__Internal")]
        NSString BNCCurrencyQAR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyRON;
        [Field("BNCCurrencyRON", "__Internal")]
        NSString BNCCurrencyRON { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyRSD;
        [Field("BNCCurrencyRSD", "__Internal")]
        NSString BNCCurrencyRSD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyRUB;
        [Field("BNCCurrencyRUB", "__Internal")]
        NSString BNCCurrencyRUB { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyRWF;
        [Field("BNCCurrencyRWF", "__Internal")]
        NSString BNCCurrencyRWF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySAR;
        [Field("BNCCurrencySAR", "__Internal")]
        NSString BNCCurrencySAR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySBD;
        [Field("BNCCurrencySBD", "__Internal")]
        NSString BNCCurrencySBD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySCR;
        [Field("BNCCurrencySCR", "__Internal")]
        NSString BNCCurrencySCR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySDG;
        [Field("BNCCurrencySDG", "__Internal")]
        NSString BNCCurrencySDG { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySEK;
        [Field("BNCCurrencySEK", "__Internal")]
        NSString BNCCurrencySEK { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySGD;
        [Field("BNCCurrencySGD", "__Internal")]
        NSString BNCCurrencySGD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySHP;
        [Field("BNCCurrencySHP", "__Internal")]
        NSString BNCCurrencySHP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySLL;
        [Field("BNCCurrencySLL", "__Internal")]
        NSString BNCCurrencySLL { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySOS;
        [Field("BNCCurrencySOS", "__Internal")]
        NSString BNCCurrencySOS { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySRD;
        [Field("BNCCurrencySRD", "__Internal")]
        NSString BNCCurrencySRD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySSP;
        [Field("BNCCurrencySSP", "__Internal")]
        NSString BNCCurrencySSP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySTD;
        [Field("BNCCurrencySTD", "__Internal")]
        NSString BNCCurrencySTD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySYP;
        [Field("BNCCurrencySYP", "__Internal")]
        NSString BNCCurrencySYP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencySZL;
        [Field("BNCCurrencySZL", "__Internal")]
        NSString BNCCurrencySZL { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyTHB;
        [Field("BNCCurrencyTHB", "__Internal")]
        NSString BNCCurrencyTHB { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyTJS;
        [Field("BNCCurrencyTJS", "__Internal")]
        NSString BNCCurrencyTJS { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyTMT;
        [Field("BNCCurrencyTMT", "__Internal")]
        NSString BNCCurrencyTMT { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyTND;
        [Field("BNCCurrencyTND", "__Internal")]
        NSString BNCCurrencyTND { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyTOP;
        [Field("BNCCurrencyTOP", "__Internal")]
        NSString BNCCurrencyTOP { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyTRY;
        [Field("BNCCurrencyTRY", "__Internal")]
        NSString BNCCurrencyTRY { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyTTD;
        [Field("BNCCurrencyTTD", "__Internal")]
        NSString BNCCurrencyTTD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyTWD;
        [Field("BNCCurrencyTWD", "__Internal")]
        NSString BNCCurrencyTWD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyTZS;
        [Field("BNCCurrencyTZS", "__Internal")]
        NSString BNCCurrencyTZS { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyUAH;
        [Field("BNCCurrencyUAH", "__Internal")]
        NSString BNCCurrencyUAH { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyUGX;
        [Field("BNCCurrencyUGX", "__Internal")]
        NSString BNCCurrencyUGX { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyUSD;
        [Field("BNCCurrencyUSD", "__Internal")]
        NSString BNCCurrencyUSD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyUSN;
        [Field("BNCCurrencyUSN", "__Internal")]
        NSString BNCCurrencyUSN { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyUYI;
        [Field("BNCCurrencyUYI", "__Internal")]
        NSString BNCCurrencyUYI { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyUYU;
        [Field("BNCCurrencyUYU", "__Internal")]
        NSString BNCCurrencyUYU { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyUZS;
        [Field("BNCCurrencyUZS", "__Internal")]
        NSString BNCCurrencyUZS { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyVEF;
        [Field("BNCCurrencyVEF", "__Internal")]
        NSString BNCCurrencyVEF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyVND;
        [Field("BNCCurrencyVND", "__Internal")]
        NSString BNCCurrencyVND { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyVUV;
        [Field("BNCCurrencyVUV", "__Internal")]
        NSString BNCCurrencyVUV { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyWST;
        [Field("BNCCurrencyWST", "__Internal")]
        NSString BNCCurrencyWST { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXAF;
        [Field("BNCCurrencyXAF", "__Internal")]
        NSString BNCCurrencyXAF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXAG;
        [Field("BNCCurrencyXAG", "__Internal")]
        NSString BNCCurrencyXAG { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXAU;
        [Field("BNCCurrencyXAU", "__Internal")]
        NSString BNCCurrencyXAU { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXBA;
        [Field("BNCCurrencyXBA", "__Internal")]
        NSString BNCCurrencyXBA { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXBB;
        [Field("BNCCurrencyXBB", "__Internal")]
        NSString BNCCurrencyXBB { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXBC;
        [Field("BNCCurrencyXBC", "__Internal")]
        NSString BNCCurrencyXBC { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXBD;
        [Field("BNCCurrencyXBD", "__Internal")]
        NSString BNCCurrencyXBD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXCD;
        [Field("BNCCurrencyXCD", "__Internal")]
        NSString BNCCurrencyXCD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXDR;
        [Field("BNCCurrencyXDR", "__Internal")]
        NSString BNCCurrencyXDR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXFU;
        [Field("BNCCurrencyXFU", "__Internal")]
        NSString BNCCurrencyXFU { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXOF;
        [Field("BNCCurrencyXOF", "__Internal")]
        NSString BNCCurrencyXOF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXPD;
        [Field("BNCCurrencyXPD", "__Internal")]
        NSString BNCCurrencyXPD { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXPF;
        [Field("BNCCurrencyXPF", "__Internal")]
        NSString BNCCurrencyXPF { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXPT;
        [Field("BNCCurrencyXPT", "__Internal")]
        NSString BNCCurrencyXPT { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXSU;
        [Field("BNCCurrencyXSU", "__Internal")]
        NSString BNCCurrencyXSU { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXTS;
        [Field("BNCCurrencyXTS", "__Internal")]
        NSString BNCCurrencyXTS { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXUA;
        [Field("BNCCurrencyXUA", "__Internal")]
        NSString BNCCurrencyXUA { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyXXX;
        [Field("BNCCurrencyXXX", "__Internal")]
        NSString BNCCurrencyXXX { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyYER;
        [Field("BNCCurrencyYER", "__Internal")]
        NSString BNCCurrencyYER { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyZAR;
        [Field("BNCCurrencyZAR", "__Internal")]
        NSString BNCCurrencyZAR { get; }

        // extern BNCCurrency _Nonnull BNCCurrencyZMW;
        [Field("BNCCurrencyZMW", "__Internal")]
        NSString BNCCurrencyZMW { get; }
    }

    // @interface BNCProduct : NSObject
    [BaseType(typeof(NSObject))]
    interface BNCProduct
    {
        // @property (nonatomic, strong) NSString * _Nullable sku;
        [NullAllowed, Export("sku", ArgumentSemantic.Strong)]
        string Sku { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable name;
        [NullAllowed, Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * _Nullable price;
        [NullAllowed, Export("price", ArgumentSemantic.Strong)]
        NSDecimalNumber Price { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable quantity;
        [NullAllowed, Export("quantity", ArgumentSemantic.Strong)]
        NSNumber Quantity { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable brand;
        [NullAllowed, Export("brand", ArgumentSemantic.Strong)]
        string Brand { get; set; }

        // @property (nonatomic, strong) BNCProductCategory _Nullable category;
        [NullAllowed, Export("category", ArgumentSemantic.Strong)]
        string Category { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable variant;
        [NullAllowed, Export("variant", ArgumentSemantic.Strong)]
        string Variant { get; set; }
    }

    // @interface BNCCommerceEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface BNCCommerceEvent
    {
        // @property (nonatomic, strong) NSDecimalNumber * _Nullable revenue;
        [NullAllowed, Export("revenue", ArgumentSemantic.Strong)]
        NSDecimalNumber Revenue { get; set; }

        // @property (nonatomic, strong) BNCCurrency _Nullable currency;
        [NullAllowed, Export("currency", ArgumentSemantic.Strong)]
        string Currency { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable transactionID;
        [NullAllowed, Export("transactionID", ArgumentSemantic.Strong)]
        string TransactionID { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * _Nullable shipping;
        [NullAllowed, Export("shipping", ArgumentSemantic.Strong)]
        NSDecimalNumber Shipping { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * _Nullable tax;
        [NullAllowed, Export("tax", ArgumentSemantic.Strong)]
        NSDecimalNumber Tax { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable coupon;
        [NullAllowed, Export("coupon", ArgumentSemantic.Strong)]
        string Coupon { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable affiliation;
        [NullAllowed, Export("affiliation", ArgumentSemantic.Strong)]
        string Affiliation { get; set; }

        // @property (nonatomic, strong) NSArray<BNCProduct *> * _Nullable products;
        [NullAllowed, Export("products", ArgumentSemantic.Strong)]
        BNCProduct[] Products { get; set; }
    }

    // @interface BranchCommerceEventRequest : BNCServerRequest <NSSecureCoding>
    [BaseType(typeof(BNCServerRequest))]
    interface BranchCommerceEventRequest : INSSecureCoding
    {
        // -(instancetype _Nonnull)initWithCommerceEvent:(BNCCommerceEvent * _Nonnull)commerceEvent metadata:(NSDictionary * _Nullable)dictionary completion:(void (^ _Nullable)(NSDictionary * _Nullable, NSError * _Nullable))callBack;
        [Export("initWithCommerceEvent:metadata:completion:")]
        IntPtr Constructor(BNCCommerceEvent commerceEvent, [NullAllowed] NSDictionary dictionary, [NullAllowed] Action<NSDictionary, NSError> callBack);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull BNC_SDK_VERSION;
        [Field("BNC_SDK_VERSION", "__Internal")]
        NSString BNC_SDK_VERSION { get; }

        // extern NSString *const _Nonnull BNC_API_BASE_URL;
        [Field("BNC_API_BASE_URL", "__Internal")]
        NSString BNC_API_BASE_URL { get; }

        // extern const BOOL BNC_API_PINNED;
        [Field("BNC_API_PINNED", "__Internal")]
        bool BNC_API_PINNED { get; }

        // extern NSString *const _Nonnull BNC_API_VERSION;
        [Field("BNC_API_VERSION", "__Internal")]
        NSString BNC_API_VERSION { get; }

        // extern NSString *const _Nonnull BNC_LINK_URL;
        [Field("BNC_LINK_URL", "__Internal")]
        NSString BNC_LINK_URL { get; }
    }

    // @interface Branch (NSError)
    //[Category]
    [BaseType(typeof(NSError))]
    [Protocol]
    interface NSError_Branch
    {
        // +(NSString * _Nonnull)bncErrorDomain;
        [Static]
        [Export("bncErrorDomain")]
        //[Verify(MethodToProperty)]
        string BncErrorDomain { get; }

        // +(NSError * _Nonnull)branchErrorWithCode:(BNCErrorCode)errorCode;
        [Static]
        [Export("branchErrorWithCode:")]
        NSError BranchErrorWithCode(BNCErrorCode errorCode);

        // +(NSError * _Nonnull)branchErrorWithCode:(BNCErrorCode)errorCode error:(NSError * _Nullable)error;
        [Static]
        [Export("branchErrorWithCode:error:")]
        NSError BranchErrorWithCode(BNCErrorCode errorCode, [NullAllowed] NSError error);

        // +(NSError * _Nonnull)branchErrorWithCode:(BNCErrorCode)errorCode localizedMessage:(NSString * _Nullable)message;
        [Static]
        [Export("branchErrorWithCode:localizedMessage:")]
        NSError BranchErrorWithCode(BNCErrorCode errorCode, [NullAllowed] string message);
    }

    // @interface BNCLinkData : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface BNCLinkData : INSSecureCoding
    {
        // @property (nonatomic, strong) NSMutableDictionary * data;
        [Export("data", ArgumentSemantic.Strong)]
        NSMutableDictionary Data { get; set; }

        // -(void)setupTags:(NSArray *)tags;
        [Export("setupTags:")]
        //[Verify(StronglyTypedNSArray)]
        void SetupTags(NSObject[] tags);

        // -(void)setupAlias:(NSString *)alias;
        [Export("setupAlias:")]
        void SetupAlias(string alias);

        // -(void)setupType:(BranchLinkType)type;
        [Export("setupType:")]
        void SetupType(BranchLinkType type);

        // -(void)setupChannel:(NSString *)channel;
        [Export("setupChannel:")]
        void SetupChannel(string channel);

        // -(void)setupFeature:(NSString *)feature;
        [Export("setupFeature:")]
        void SetupFeature(string feature);

        // -(void)setupStage:(NSString *)stage;
        [Export("setupStage:")]
        void SetupStage(string stage);

        // -(void)setupCampaign:(NSString *)campaign;
        [Export("setupCampaign:")]
        void SetupCampaign(string campaign);

        // -(void)setupParams:(NSDictionary *)params;
        [Export("setupParams:")]
        void SetupParams(NSDictionary @params);

        // -(void)setupMatchDuration:(NSUInteger)duration;
        [Export("setupMatchDuration:")]
        void SetupMatchDuration(nuint duration);

        // -(void)setupIgnoreUAString:(NSString *)ignoreUAString;
        [Export("setupIgnoreUAString:")]
        void SetupIgnoreUAString(string ignoreUAString);
    }

    // @interface BNCLinkCache : NSObject
    [BaseType(typeof(NSObject))]
    interface BNCLinkCache
    {
        // -(void)setObject:(NSString *)anObject forKey:(BNCLinkData *)aKey;
        [Export("setObject:forKey:")]
        void SetObject(string anObject, BNCLinkData aKey);

        // -(NSString *)objectForKey:(BNCLinkData *)aKey;
        [Export("objectForKey:")]
        string ObjectForKey(BNCLinkData aKey);

        // -(void)clear;
        [Export("clear")]
        void Clear();
    }

    // @interface BNCServerRequestQueue : NSObject
    [BaseType(typeof(NSObject))]
    interface BNCServerRequestQueue
    {
        // -(void)enqueue:(BNCServerRequest *)request;
        [Export("enqueue:")]
        void Enqueue(BNCServerRequest request);

        // -(BNCServerRequest *)dequeue;
        [Export("dequeue")]
        //[Verify(MethodToProperty)]
        BNCServerRequest Dequeue { get; }

        // -(BNCServerRequest *)peek;
        [Export("peek")]
        //[Verify(MethodToProperty)]
        BNCServerRequest Peek { get; }

        // -(BNCServerRequest *)peekAt:(NSUInteger)index;
        [Export("peekAt:")]
        BNCServerRequest PeekAt(nuint index);

        // -(void)insert:(BNCServerRequest *)request at:(NSUInteger)index;
        [Export("insert:at:")]
        void Insert(BNCServerRequest request, nuint index);

        // -(BNCServerRequest *)removeAt:(NSUInteger)index;
        [Export("removeAt:")]
        BNCServerRequest RemoveAt(nuint index);

        // -(void)remove:(BNCServerRequest *)request;
        [Export("remove:")]
        void Remove(BNCServerRequest request);

        // -(void)persistEventually;
        [Export("persistEventually")]
        void PersistEventually();

        // -(void)persistImmediately;
        [Export("persistImmediately")]
        void PersistImmediately();

        // -(void)clearQueue;
        [Export("clearQueue")]
        void ClearQueue();

        // -(BOOL)containsInstallOrOpen;
        [Export("containsInstallOrOpen")]
        //[Verify(MethodToProperty)]
        bool ContainsInstallOrOpen { get; }

        // -(BOOL)removeInstallOrOpen;
        [Export("removeInstallOrOpen")]
        //[Verify(MethodToProperty)]
        bool RemoveInstallOrOpen { get; }

        // -(BOOL)containsClose;
        [Export("containsClose")]
        //[Verify(MethodToProperty)]
        bool ContainsClose { get; }

        //// -(BranchOpenRequest *)moveInstallOrOpenToFront:(NSInteger)networkCount;
        //[Export("moveInstallOrOpenToFront:")]
        //BranchOpenRequest MoveInstallOrOpenToFront(nint networkCount);

        // +(id)getInstance;
        [Static]
        [Export("getInstance")]
        //[Verify(MethodToProperty)]
        NSObject Instance { get; }

        // @property (readonly, assign, atomic) NSInteger queueDepth;
        [Export("queueDepth")]
        nint QueueDepth { get; }

        // @property (readonly, assign, atomic) BOOL isDirty;
        [Export("isDirty")]
        bool IsDirty { get; }
    }

    // @protocol BranchActivityItemProviderDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface BranchActivityItemProviderDelegate
    {
        // @optional -(NSDictionary *)activityItemParamsForChannel:(NSString *)channel;
        [Export("activityItemParamsForChannel:")]
        NSDictionary ActivityItemParamsForChannel(string channel);

        // @optional -(NSArray *)activityItemTagsForChannel:(NSString *)channel;
        [Export("activityItemTagsForChannel:")]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] ActivityItemTagsForChannel(string channel);

        // @optional -(NSString *)activityItemFeatureForChannel:(NSString *)channel;
        [Export("activityItemFeatureForChannel:")]
        string ActivityItemFeatureForChannel(string channel);

        // @optional -(NSString *)activityItemStageForChannel:(NSString *)channel;
        [Export("activityItemStageForChannel:")]
        string ActivityItemStageForChannel(string channel);

        // @optional -(NSString *)activityItemCampaignForChannel:(NSString *)channel;
        [Export("activityItemCampaignForChannel:")]
        string ActivityItemCampaignForChannel(string channel);

        // @optional -(NSString *)activityItemAliasForChannel:(NSString *)channel;
        [Export("activityItemAliasForChannel:")]
        string ActivityItemAliasForChannel(string channel);

        // @optional -(NSString *)activityItemOverrideChannelForChannel:(NSString *)channel;
        [Export("activityItemOverrideChannelForChannel:")]
        string ActivityItemOverrideChannelForChannel(string channel);
    }

    // @interface BranchActivityItemProvider : UIActivityItemProvider
    [BaseType(typeof(UIActivityItemProvider))]
    interface BranchActivityItemProvider
    {
        // -(id)initWithParams:(NSDictionary *)params andTags:(NSArray *)tags andFeature:(NSString *)feature andStage:(NSString *)stage andAlias:(NSString *)alias __attribute__((deprecated("Use the delegate method instead")));
        [Export("initWithParams:andTags:andFeature:andStage:andAlias:")]
        //[Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSDictionary @params, NSObject[] tags, string feature, string stage, string alias);

        // -(id)initWithParams:(NSDictionary *)params tags:(NSArray *)tags feature:(NSString *)feature stage:(NSString *)stage campaign:(NSString *)campaign alias:(NSString *)alias delegate:(id<BranchActivityItemProviderDelegate>)delegate;
        [Export("initWithParams:tags:feature:stage:campaign:alias:delegate:")]
        //[Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSDictionary @params, NSObject[] tags, string feature, string stage, string campaign, string alias, BranchActivityItemProviderDelegate @delegate);

        // +(NSString *)humanReadableChannelWithActivityType:(NSString *)activityString;
        [Static]
        [Export("humanReadableChannelWithActivityType:")]
        string HumanReadableChannelWithActivityType(string activityString);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const BRANCH_REQUEST_KEY_BRANCH_IDENTITY;
        [Field("BRANCH_REQUEST_KEY_BRANCH_IDENTITY", "__Internal")]
        NSString BRANCH_REQUEST_KEY_BRANCH_IDENTITY { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_DEVELOPER_IDENTITY;
        [Field("BRANCH_REQUEST_KEY_DEVELOPER_IDENTITY", "__Internal")]
        NSString BRANCH_REQUEST_KEY_DEVELOPER_IDENTITY { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_DEVICE_FINGERPRINT_ID;
        [Field("BRANCH_REQUEST_KEY_DEVICE_FINGERPRINT_ID", "__Internal")]
        NSString BRANCH_REQUEST_KEY_DEVICE_FINGERPRINT_ID { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_SESSION_ID;
        [Field("BRANCH_REQUEST_KEY_SESSION_ID", "__Internal")]
        NSString BRANCH_REQUEST_KEY_SESSION_ID { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_ACTION;
        [Field("BRANCH_REQUEST_KEY_ACTION", "__Internal")]
        NSString BRANCH_REQUEST_KEY_ACTION { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_STATE;
        [Field("BRANCH_REQUEST_KEY_STATE", "__Internal")]
        NSString BRANCH_REQUEST_KEY_STATE { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_BUCKET;
        [Field("BRANCH_REQUEST_KEY_BUCKET", "__Internal")]
        NSString BRANCH_REQUEST_KEY_BUCKET { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_AMOUNT;
        [Field("BRANCH_REQUEST_KEY_AMOUNT", "__Internal")]
        NSString BRANCH_REQUEST_KEY_AMOUNT { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_LENGTH;
        [Field("BRANCH_REQUEST_KEY_LENGTH", "__Internal")]
        NSString BRANCH_REQUEST_KEY_LENGTH { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_DIRECTION;
        [Field("BRANCH_REQUEST_KEY_DIRECTION", "__Internal")]
        NSString BRANCH_REQUEST_KEY_DIRECTION { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_STARTING_TRANSACTION_ID;
        [Field("BRANCH_REQUEST_KEY_STARTING_TRANSACTION_ID", "__Internal")]
        NSString BRANCH_REQUEST_KEY_STARTING_TRANSACTION_ID { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_REFERRAL_USAGE_TYPE;
        [Field("BRANCH_REQUEST_KEY_REFERRAL_USAGE_TYPE", "__Internal")]
        NSString BRANCH_REQUEST_KEY_REFERRAL_USAGE_TYPE { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_REFERRAL_TYPE;
        [Field("BRANCH_REQUEST_KEY_REFERRAL_TYPE", "__Internal")]
        NSString BRANCH_REQUEST_KEY_REFERRAL_TYPE { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_REFERRAL_CREATION_SOURCE;
        [Field("BRANCH_REQUEST_KEY_REFERRAL_CREATION_SOURCE", "__Internal")]
        NSString BRANCH_REQUEST_KEY_REFERRAL_CREATION_SOURCE { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_REFERRAL_PREFIX;
        [Field("BRANCH_REQUEST_KEY_REFERRAL_PREFIX", "__Internal")]
        NSString BRANCH_REQUEST_KEY_REFERRAL_PREFIX { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_REFERRAL_EXPIRATION;
        [Field("BRANCH_REQUEST_KEY_REFERRAL_EXPIRATION", "__Internal")]
        NSString BRANCH_REQUEST_KEY_REFERRAL_EXPIRATION { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_SOURCE;
        [Field("BRANCH_REQUEST_KEY_URL_SOURCE", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_SOURCE { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_TAGS;
        [Field("BRANCH_REQUEST_KEY_URL_TAGS", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_TAGS { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_LINK_TYPE;
        [Field("BRANCH_REQUEST_KEY_URL_LINK_TYPE", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_LINK_TYPE { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_ALIAS;
        [Field("BRANCH_REQUEST_KEY_URL_ALIAS", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_ALIAS { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_CHANNEL;
        [Field("BRANCH_REQUEST_KEY_URL_CHANNEL", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_CHANNEL { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_FEATURE;
        [Field("BRANCH_REQUEST_KEY_URL_FEATURE", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_FEATURE { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_STAGE;
        [Field("BRANCH_REQUEST_KEY_URL_STAGE", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_STAGE { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_CAMPAIGN;
        [Field("BRANCH_REQUEST_KEY_URL_CAMPAIGN", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_CAMPAIGN { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_DURATION;
        [Field("BRANCH_REQUEST_KEY_URL_DURATION", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_DURATION { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_DATA;
        [Field("BRANCH_REQUEST_KEY_URL_DATA", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_DATA { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URL_IGNORE_UA_STRING;
        [Field("BRANCH_REQUEST_KEY_URL_IGNORE_UA_STRING", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URL_IGNORE_UA_STRING { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_HARDWARE_ID;
        [Field("BRANCH_REQUEST_KEY_HARDWARE_ID", "__Internal")]
        NSString BRANCH_REQUEST_KEY_HARDWARE_ID { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_HARDWARE_ID_TYPE;
        [Field("BRANCH_REQUEST_KEY_HARDWARE_ID_TYPE", "__Internal")]
        NSString BRANCH_REQUEST_KEY_HARDWARE_ID_TYPE { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_IS_HARDWARE_ID_REAL;
        [Field("BRANCH_REQUEST_KEY_IS_HARDWARE_ID_REAL", "__Internal")]
        NSString BRANCH_REQUEST_KEY_IS_HARDWARE_ID_REAL { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_IOS_VENDOR_ID;
        [Field("BRANCH_REQUEST_KEY_IOS_VENDOR_ID", "__Internal")]
        NSString BRANCH_REQUEST_KEY_IOS_VENDOR_ID { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_AD_TRACKING_ENABLED;
        [Field("BRANCH_REQUEST_KEY_AD_TRACKING_ENABLED", "__Internal")]
        NSString BRANCH_REQUEST_KEY_AD_TRACKING_ENABLED { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_DEBUG;
        [Field("BRANCH_REQUEST_KEY_DEBUG", "__Internal")]
        NSString BRANCH_REQUEST_KEY_DEBUG { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_BUNDLE_ID;
        [Field("BRANCH_REQUEST_KEY_BUNDLE_ID", "__Internal")]
        NSString BRANCH_REQUEST_KEY_BUNDLE_ID { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_TEAM_ID;
        [Field("BRANCH_REQUEST_KEY_TEAM_ID", "__Internal")]
        NSString BRANCH_REQUEST_KEY_TEAM_ID { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_APP_VERSION;
        [Field("BRANCH_REQUEST_KEY_APP_VERSION", "__Internal")]
        NSString BRANCH_REQUEST_KEY_APP_VERSION { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_OS;
        [Field("BRANCH_REQUEST_KEY_OS", "__Internal")]
        NSString BRANCH_REQUEST_KEY_OS { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_OS_VERSION;
        [Field("BRANCH_REQUEST_KEY_OS_VERSION", "__Internal")]
        NSString BRANCH_REQUEST_KEY_OS_VERSION { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_URI_SCHEME;
        [Field("BRANCH_REQUEST_KEY_URI_SCHEME", "__Internal")]
        NSString BRANCH_REQUEST_KEY_URI_SCHEME { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_CHECKED_FACEBOOK_APPLINKS;
        [Field("BRANCH_REQUEST_KEY_CHECKED_FACEBOOK_APPLINKS", "__Internal")]
        NSString BRANCH_REQUEST_KEY_CHECKED_FACEBOOK_APPLINKS { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_CHECKED_APPLE_AD_ATTRIBUTION;
        [Field("BRANCH_REQUEST_KEY_CHECKED_APPLE_AD_ATTRIBUTION", "__Internal")]
        NSString BRANCH_REQUEST_KEY_CHECKED_APPLE_AD_ATTRIBUTION { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_LINK_IDENTIFIER;
        [Field("BRANCH_REQUEST_KEY_LINK_IDENTIFIER", "__Internal")]
        NSString BRANCH_REQUEST_KEY_LINK_IDENTIFIER { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_SPOTLIGHT_IDENTIFIER;
        [Field("BRANCH_REQUEST_KEY_SPOTLIGHT_IDENTIFIER", "__Internal")]
        NSString BRANCH_REQUEST_KEY_SPOTLIGHT_IDENTIFIER { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_UNIVERSAL_LINK_URL;
        [Field("BRANCH_REQUEST_KEY_UNIVERSAL_LINK_URL", "__Internal")]
        NSString BRANCH_REQUEST_KEY_UNIVERSAL_LINK_URL { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_BRAND;
        [Field("BRANCH_REQUEST_KEY_BRAND", "__Internal")]
        NSString BRANCH_REQUEST_KEY_BRAND { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_MODEL;
        [Field("BRANCH_REQUEST_KEY_MODEL", "__Internal")]
        NSString BRANCH_REQUEST_KEY_MODEL { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_SCREEN_WIDTH;
        [Field("BRANCH_REQUEST_KEY_SCREEN_WIDTH", "__Internal")]
        NSString BRANCH_REQUEST_KEY_SCREEN_WIDTH { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_SCREEN_HEIGHT;
        [Field("BRANCH_REQUEST_KEY_SCREEN_HEIGHT", "__Internal")]
        NSString BRANCH_REQUEST_KEY_SCREEN_HEIGHT { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_IS_SIMULATOR;
        [Field("BRANCH_REQUEST_KEY_IS_SIMULATOR", "__Internal")]
        NSString BRANCH_REQUEST_KEY_IS_SIMULATOR { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_LOG;
        [Field("BRANCH_REQUEST_KEY_LOG", "__Internal")]
        NSString BRANCH_REQUEST_KEY_LOG { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_EXTERNAL_INTENT_URI;
        [Field("BRANCH_REQUEST_KEY_EXTERNAL_INTENT_URI", "__Internal")]
        NSString BRANCH_REQUEST_KEY_EXTERNAL_INTENT_URI { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_INSTRUMENTATION;
        [Field("BRANCH_REQUEST_KEY_INSTRUMENTATION", "__Internal")]
        NSString BRANCH_REQUEST_KEY_INSTRUMENTATION { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_APPLE_RECEIPT;
        [Field("BRANCH_REQUEST_KEY_APPLE_RECEIPT", "__Internal")]
        NSString BRANCH_REQUEST_KEY_APPLE_RECEIPT { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_APPLE_TESTFLIGHT;
        [Field("BRANCH_REQUEST_KEY_APPLE_TESTFLIGHT", "__Internal")]
        NSString BRANCH_REQUEST_KEY_APPLE_TESTFLIGHT { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_SET_IDENTITY;
        [Field("BRANCH_REQUEST_ENDPOINT_SET_IDENTITY", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_SET_IDENTITY { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_APP_LINK_SETTINGS;
        [Field("BRANCH_REQUEST_ENDPOINT_APP_LINK_SETTINGS", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_APP_LINK_SETTINGS { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_LOGOUT;
        [Field("BRANCH_REQUEST_ENDPOINT_LOGOUT", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_LOGOUT { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_USER_COMPLETED_ACTION;
        [Field("BRANCH_REQUEST_ENDPOINT_USER_COMPLETED_ACTION", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_USER_COMPLETED_ACTION { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_GET_SHORT_URL;
        [Field("BRANCH_REQUEST_ENDPOINT_GET_SHORT_URL", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_GET_SHORT_URL { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_CLOSE;
        [Field("BRANCH_REQUEST_ENDPOINT_CLOSE", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_CLOSE { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_OPEN;
        [Field("BRANCH_REQUEST_ENDPOINT_OPEN", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_OPEN { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_INSTALL;
        [Field("BRANCH_REQUEST_ENDPOINT_INSTALL", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_INSTALL { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_REGISTER_VIEW;
        [Field("BRANCH_REQUEST_ENDPOINT_REGISTER_VIEW", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_REGISTER_VIEW { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_CPID;
        [Field("BRANCH_REQUEST_ENDPOINT_CPID", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_CPID { get; }

        // extern NSString *const BRANCH_REQUEST_ENDPOINT_LATD;
        [Field("BRANCH_REQUEST_ENDPOINT_LATD", "__Internal")]
        NSString BRANCH_REQUEST_ENDPOINT_LATD { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_BRANCH_IDENTITY;
        [Field("BRANCH_RESPONSE_KEY_BRANCH_IDENTITY", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_BRANCH_IDENTITY { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_SESSION_ID;
        [Field("BRANCH_RESPONSE_KEY_SESSION_ID", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_SESSION_ID { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_USER_URL;
        [Field("BRANCH_RESPONSE_KEY_USER_URL", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_USER_URL { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_INSTALL_PARAMS;
        [Field("BRANCH_RESPONSE_KEY_INSTALL_PARAMS", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_INSTALL_PARAMS { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_REFERRER;
        [Field("BRANCH_RESPONSE_KEY_REFERRER", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_REFERRER { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_REFERREE;
        [Field("BRANCH_RESPONSE_KEY_REFERREE", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_REFERREE { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_URL;
        [Field("BRANCH_RESPONSE_KEY_URL", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_URL { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_SPOTLIGHT_IDENTIFIER;
        [Field("BRANCH_RESPONSE_KEY_SPOTLIGHT_IDENTIFIER", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_SPOTLIGHT_IDENTIFIER { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_DEVELOPER_IDENTITY;
        [Field("BRANCH_RESPONSE_KEY_DEVELOPER_IDENTITY", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_DEVELOPER_IDENTITY { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_DEVICE_FINGERPRINT_ID;
        [Field("BRANCH_RESPONSE_KEY_DEVICE_FINGERPRINT_ID", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_DEVICE_FINGERPRINT_ID { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_SESSION_DATA;
        [Field("BRANCH_RESPONSE_KEY_SESSION_DATA", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_SESSION_DATA { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_CLICKED_BRANCH_LINK;
        [Field("BRANCH_RESPONSE_KEY_CLICKED_BRANCH_LINK", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_CLICKED_BRANCH_LINK { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_BRANCH_VIEW_DATA;
        [Field("BRANCH_RESPONSE_KEY_BRANCH_VIEW_DATA", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_BRANCH_VIEW_DATA { get; }

        // extern NSString *const BRANCH_RESPONSE_KEY_BRANCH_REFERRING_LINK;
        [Field("BRANCH_RESPONSE_KEY_BRANCH_REFERRING_LINK", "__Internal")]
        NSString BRANCH_RESPONSE_KEY_BRANCH_REFERRING_LINK { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_OG_TITLE;
        [Field("BRANCH_LINK_DATA_KEY_OG_TITLE", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_OG_TITLE { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_OG_DESCRIPTION;
        [Field("BRANCH_LINK_DATA_KEY_OG_DESCRIPTION", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_OG_DESCRIPTION { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_OG_IMAGE_URL;
        [Field("BRANCH_LINK_DATA_KEY_OG_IMAGE_URL", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_OG_IMAGE_URL { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_TITLE;
        [Field("BRANCH_LINK_DATA_KEY_TITLE", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_TITLE { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_DESCRIPTION;
        [Field("BRANCH_LINK_DATA_KEY_DESCRIPTION", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_DESCRIPTION { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_PUBLICLY_INDEXABLE;
        [Field("BRANCH_LINK_DATA_KEY_PUBLICLY_INDEXABLE", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_PUBLICLY_INDEXABLE { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_LOCALLY_INDEXABLE;
        [Field("BRANCH_LINK_DATA_KEY_LOCALLY_INDEXABLE", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_LOCALLY_INDEXABLE { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_TYPE;
        [Field("BRANCH_LINK_DATA_KEY_TYPE", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_TYPE { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_THUMBNAIL_URL;
        [Field("BRANCH_LINK_DATA_KEY_THUMBNAIL_URL", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_THUMBNAIL_URL { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_KEYWORDS;
        [Field("BRANCH_LINK_DATA_KEY_KEYWORDS", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_KEYWORDS { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_CANONICAL_IDENTIFIER;
        [Field("BRANCH_LINK_DATA_KEY_CANONICAL_IDENTIFIER", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_CANONICAL_IDENTIFIER { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_CANONICAL_URL;
        [Field("BRANCH_LINK_DATA_KEY_CANONICAL_URL", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_CANONICAL_URL { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_CONTENT_EXPIRATION_DATE;
        [Field("BRANCH_LINK_DATA_KEY_CONTENT_EXPIRATION_DATE", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_CONTENT_EXPIRATION_DATE { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_CONTENT_TYPE;
        [Field("BRANCH_LINK_DATA_KEY_CONTENT_TYPE", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_CONTENT_TYPE { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_EMAIL_SUBJECT;
        [Field("BRANCH_LINK_DATA_KEY_EMAIL_SUBJECT", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_EMAIL_SUBJECT { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_EMAIL_HTML_HEADER;
        [Field("BRANCH_LINK_DATA_KEY_EMAIL_HTML_HEADER", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_EMAIL_HTML_HEADER { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_EMAIL_HTML_FOOTER;
        [Field("BRANCH_LINK_DATA_KEY_EMAIL_HTML_FOOTER", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_EMAIL_HTML_FOOTER { get; }

        // extern NSString *const BRANCH_LINK_DATA_KEY_EMAIL_HTML_LINK_TEXT;
        [Field("BRANCH_LINK_DATA_KEY_EMAIL_HTML_LINK_TEXT", "__Internal")]
        NSString BRANCH_LINK_DATA_KEY_EMAIL_HTML_LINK_TEXT { get; }

        // extern NSString *const BRANCH_SPOTLIGHT_PREFIX;
        [Field("BRANCH_SPOTLIGHT_PREFIX", "__Internal")]
        NSString BRANCH_SPOTLIGHT_PREFIX { get; }

        // extern NSString *const BRANCH_MANIFEST_VERSION_KEY;
        [Field("BRANCH_MANIFEST_VERSION_KEY", "__Internal")]
        NSString BRANCH_MANIFEST_VERSION_KEY { get; }

        // extern NSString *const BRANCH_HASH_MODE_KEY;
        [Field("BRANCH_HASH_MODE_KEY", "__Internal")]
        NSString BRANCH_HASH_MODE_KEY { get; }

        // extern NSString *const BRANCH_MANIFEST_KEY;
        [Field("BRANCH_MANIFEST_KEY", "__Internal")]
        NSString BRANCH_MANIFEST_KEY { get; }

        // extern NSString *const BRANCH_PATH_KEY;
        [Field("BRANCH_PATH_KEY", "__Internal")]
        NSString BRANCH_PATH_KEY { get; }

        // extern NSString *const BRANCH_FILTERED_KEYS;
        [Field("BRANCH_FILTERED_KEYS", "__Internal")]
        NSString BRANCH_FILTERED_KEYS { get; }

        // extern NSString *const BRANCH_MAX_TEXT_LEN_KEY;
        [Field("BRANCH_MAX_TEXT_LEN_KEY", "__Internal")]
        NSString BRANCH_MAX_TEXT_LEN_KEY { get; }

        // extern NSString *const BRANCH_MAX_VIEW_HISTORY_LENGTH;
        [Field("BRANCH_MAX_VIEW_HISTORY_LENGTH", "__Internal")]
        NSString BRANCH_MAX_VIEW_HISTORY_LENGTH { get; }

        // extern NSString *const BRANCH_MAX_PACKET_SIZE_KEY;
        [Field("BRANCH_MAX_PACKET_SIZE_KEY", "__Internal")]
        NSString BRANCH_MAX_PACKET_SIZE_KEY { get; }

        // extern NSString *const BRANCH_CONTENT_DISCOVER_KEY;
        [Field("BRANCH_CONTENT_DISCOVER_KEY", "__Internal")]
        NSString BRANCH_CONTENT_DISCOVER_KEY { get; }

        // extern NSString *const BRANCH_BUNDLE_IDENTIFIER;
        [Field("BRANCH_BUNDLE_IDENTIFIER", "__Internal")]
        NSString BRANCH_BUNDLE_IDENTIFIER { get; }

        // extern NSString *const BRANCH_TIME_STAMP_KEY;
        [Field("BRANCH_TIME_STAMP_KEY", "__Internal")]
        NSString BRANCH_TIME_STAMP_KEY { get; }

        // extern NSString *const BRANCH_TIME_STAMP_CLOSE_KEY;
        [Field("BRANCH_TIME_STAMP_CLOSE_KEY", "__Internal")]
        NSString BRANCH_TIME_STAMP_CLOSE_KEY { get; }

        // extern NSString *const BRANCH_NAV_PATH_KEY;
        [Field("BRANCH_NAV_PATH_KEY", "__Internal")]
        NSString BRANCH_NAV_PATH_KEY { get; }

        // extern NSString *const BRANCH_REFERRAL_LINK_KEY;
        [Field("BRANCH_REFERRAL_LINK_KEY", "__Internal")]
        NSString BRANCH_REFERRAL_LINK_KEY { get; }

        // extern NSString *const BRANCH_CONTENT_LINK_KEY;
        [Field("BRANCH_CONTENT_LINK_KEY", "__Internal")]
        NSString BRANCH_CONTENT_LINK_KEY { get; }

        // extern NSString *const BRANCH_CONTENT_META_DATA_KEY;
        [Field("BRANCH_CONTENT_META_DATA_KEY", "__Internal")]
        NSString BRANCH_CONTENT_META_DATA_KEY { get; }

        // extern NSString *const BRANCH_VIEW_KEY;
        [Field("BRANCH_VIEW_KEY", "__Internal")]
        NSString BRANCH_VIEW_KEY { get; }

        // extern NSString *const BRANCH_CONTENT_DATA_KEY;
        [Field("BRANCH_CONTENT_DATA_KEY", "__Internal")]
        NSString BRANCH_CONTENT_DATA_KEY { get; }

        // extern NSString *const BRANCH_CONTENT_KEYS_KEY;
        [Field("BRANCH_CONTENT_KEYS_KEY", "__Internal")]
        NSString BRANCH_CONTENT_KEYS_KEY { get; }

        // extern NSString *const BRANCH_PACKAGE_NAME_KEY;
        [Field("BRANCH_PACKAGE_NAME_KEY", "__Internal")]
        NSString BRANCH_PACKAGE_NAME_KEY { get; }

        // extern NSString *const BRANCH_ENTITIES_KEY;
        [Field("BRANCH_ENTITIES_KEY", "__Internal")]
        NSString BRANCH_ENTITIES_KEY { get; }

        // extern NSString *const BRANCH_REQUEST_KEY_SEARCH_AD;
        [Field("BRANCH_REQUEST_KEY_SEARCH_AD", "__Internal")]
        NSString BRANCH_REQUEST_KEY_SEARCH_AD { get; }

        // extern NSString *const BRANCH_CRASHLYTICS_SDK_VERSION_KEY;
        [Field("BRANCH_CRASHLYTICS_SDK_VERSION_KEY", "__Internal")]
        NSString BRANCH_CRASHLYTICS_SDK_VERSION_KEY { get; }

        // extern NSString *const BRANCH_CRASHLYTICS_FINGERPRINT_ID_KEY;
        [Field("BRANCH_CRASHLYTICS_FINGERPRINT_ID_KEY", "__Internal")]
        NSString BRANCH_CRASHLYTICS_FINGERPRINT_ID_KEY { get; }

        // extern NSString *const BRANCH_CRASHLYTICS_LOW_MEMORY_KEY;
        [Field("BRANCH_CRASHLYTICS_LOW_MEMORY_KEY", "__Internal")]
        NSString BRANCH_CRASHLYTICS_LOW_MEMORY_KEY { get; }
    }

    // @interface BranchCSSearchableItemAttributeSet : CSSearchableItemAttributeSet
    [BaseType(typeof(CSSearchableItemAttributeSet))]
    interface BranchCSSearchableItemAttributeSet
    {
        // -(id)initWithContentType:(NSString *)type;
        [Export("initWithContentType:")]
        IntPtr Constructor(string type);

        // -(void)indexWithCallback:(void (^)(NSString *, NSString *, NSError *))callback;
        [Export("indexWithCallback:")]
        void IndexWithCallback(Action<NSString, NSString, NSError> callback);

        // @property (nonatomic, strong) NSDictionary * params;
        [Export("params", ArgumentSemantic.Strong)]
        NSDictionary Params { get; set; }

        // @property (nonatomic, strong) NSSet * keywords;
        [Export("keywords", ArgumentSemantic.Strong)]
        NSSet Keywords { get; set; }

        // @property (nonatomic) BOOL publiclyIndexable;
        [Export("publiclyIndexable")]
        bool PubliclyIndexable { get; set; }
    }

    //// @protocol BranchDeepLinkingControllerCompletionDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    //[BaseType(typeof(NSObject))]
    //interface BranchDeepLinkingControllerCompletionDelegate
    //{
    //    // @required -(void)deepLinkingControllerCompleted __attribute__((deprecated("This API is deprecated. Instead, use deepLinkingControllerCompletedFrom: viewController")));
    //    [Abstract]
    //    [Export("deepLinkingControllerCompleted")]
    //    void DeepLinkingControllerCompleted();

    //    // @required -(void)deepLinkingControllerCompletedFrom:(UIViewController *)viewController;
    //    [Abstract]
    //    [Export("deepLinkingControllerCompletedFrom:")]
    //    void DeepLinkingControllerCompletedFrom(UIViewController viewController);
    //}

    //// @protocol BranchDeepLinkingController <NSObject>
    ///*
    //  Check whether adding [Model] to this declaration is appropriate.
    //  [Model] is used to generate a C# class that implements this protocol,
    //  and might be useful for protocols that consumers are supposed to implement,
    //  since consumers can subclass the generated class instead of implementing
    //  the generated interface. If consumers are not supposed to implement this
    //  protocol, then [Model] is redundant and will generate code that will never
    //  be used.
    //*/
    //[Protocol]
    //[BaseType(typeof(NSObject))]
    //interface BranchDeepLinkingController
    //{
    //    // @required -(void)configureControlWithData:(NSDictionary *)data;
    //    [Abstract]
    //    [Export("configureControlWithData:")]
    //    void ConfigureControlWithData(NSDictionary data);

    //    [Wrap("WeakDeepLinkingCompletionDelegate"), Abstract]
    //    BranchDeepLinkingControllerCompletionDelegate DeepLinkingCompletionDelegate { get; set; }

    //    // @required @property (nonatomic, weak) id<BranchDeepLinkingControllerCompletionDelegate> deepLinkingCompletionDelegate;
    //    [Abstract]
    //    [NullAllowed, Export("deepLinkingCompletionDelegate", ArgumentSemantic.Weak)]
    //    NSObject WeakDeepLinkingCompletionDelegate { get; set; }
    //}

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern BranchContentSchema _Nonnull BranchContentSchemaCommerceAuction;
        [Field("BranchContentSchemaCommerceAuction", "__Internal")]
        NSString BranchContentSchemaCommerceAuction { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaCommerceBusiness;
        [Field("BranchContentSchemaCommerceBusiness", "__Internal")]
        NSString BranchContentSchemaCommerceBusiness { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaCommerceOther;
        [Field("BranchContentSchemaCommerceOther", "__Internal")]
        NSString BranchContentSchemaCommerceOther { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaCommerceProduct;
        [Field("BranchContentSchemaCommerceProduct", "__Internal")]
        NSString BranchContentSchemaCommerceProduct { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaCommerceRestaurant;
        [Field("BranchContentSchemaCommerceRestaurant", "__Internal")]
        NSString BranchContentSchemaCommerceRestaurant { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaCommerceService;
        [Field("BranchContentSchemaCommerceService", "__Internal")]
        NSString BranchContentSchemaCommerceService { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaCommerceTravelFlight;
        [Field("BranchContentSchemaCommerceTravelFlight", "__Internal")]
        NSString BranchContentSchemaCommerceTravelFlight { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaCommerceTravelHotel;
        [Field("BranchContentSchemaCommerceTravelHotel", "__Internal")]
        NSString BranchContentSchemaCommerceTravelHotel { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaCommerceTravelOther;
        [Field("BranchContentSchemaCommerceTravelOther", "__Internal")]
        NSString BranchContentSchemaCommerceTravelOther { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaGameState;
        [Field("BranchContentSchemaGameState", "__Internal")]
        NSString BranchContentSchemaGameState { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaMediaImage;
        [Field("BranchContentSchemaMediaImage", "__Internal")]
        NSString BranchContentSchemaMediaImage { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaMediaMixed;
        [Field("BranchContentSchemaMediaMixed", "__Internal")]
        NSString BranchContentSchemaMediaMixed { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaMediaMusic;
        [Field("BranchContentSchemaMediaMusic", "__Internal")]
        NSString BranchContentSchemaMediaMusic { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaMediaOther;
        [Field("BranchContentSchemaMediaOther", "__Internal")]
        NSString BranchContentSchemaMediaOther { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaMediaVideo;
        [Field("BranchContentSchemaMediaVideo", "__Internal")]
        NSString BranchContentSchemaMediaVideo { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaOther;
        [Field("BranchContentSchemaOther", "__Internal")]
        NSString BranchContentSchemaOther { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaTextArticle;
        [Field("BranchContentSchemaTextArticle", "__Internal")]
        NSString BranchContentSchemaTextArticle { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaTextBlog;
        [Field("BranchContentSchemaTextBlog", "__Internal")]
        NSString BranchContentSchemaTextBlog { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaTextOther;
        [Field("BranchContentSchemaTextOther", "__Internal")]
        NSString BranchContentSchemaTextOther { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaTextRecipe;
        [Field("BranchContentSchemaTextRecipe", "__Internal")]
        NSString BranchContentSchemaTextRecipe { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaTextReview;
        [Field("BranchContentSchemaTextReview", "__Internal")]
        NSString BranchContentSchemaTextReview { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaTextSearchResults;
        [Field("BranchContentSchemaTextSearchResults", "__Internal")]
        NSString BranchContentSchemaTextSearchResults { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaTextStory;
        [Field("BranchContentSchemaTextStory", "__Internal")]
        NSString BranchContentSchemaTextStory { get; }

        // extern BranchContentSchema _Nonnull BranchContentSchemaTextTechnicalDoc;
        [Field("BranchContentSchemaTextTechnicalDoc", "__Internal")]
        NSString BranchContentSchemaTextTechnicalDoc { get; }

        // extern BranchCondition _Nonnull BranchConditionOther;
        [Field("BranchConditionOther", "__Internal")]
        NSString BranchConditionOther { get; }

        // extern BranchCondition _Nonnull BranchConditionNew;
        [Field("BranchConditionNew", "__Internal")]
        NSString BranchConditionNew { get; }

        // extern BranchCondition _Nonnull BranchConditionExcellent;
        [Field("BranchConditionExcellent", "__Internal")]
        NSString BranchConditionExcellent { get; }

        // extern BranchCondition _Nonnull BranchConditionGood;
        [Field("BranchConditionGood", "__Internal")]
        NSString BranchConditionGood { get; }

        // extern BranchCondition _Nonnull BranchConditionFair;
        [Field("BranchConditionFair", "__Internal")]
        NSString BranchConditionFair { get; }

        // extern BranchCondition _Nonnull BranchConditionPoor;
        [Field("BranchConditionPoor", "__Internal")]
        NSString BranchConditionPoor { get; }

        // extern BranchCondition _Nonnull BranchConditionUsed;
        [Field("BranchConditionUsed", "__Internal")]
        NSString BranchConditionUsed { get; }

        // extern BranchCondition _Nonnull BranchConditionRefurbished;
        [Field("BranchConditionRefurbished", "__Internal")]
        NSString BranchConditionRefurbished { get; }
    }

    // @interface BranchContentMetadata : NSObject
    [BaseType(typeof(NSObject))]
    interface BranchContentMetadata
    {
        // @property (nonatomic, strong) BranchContentSchema _Nullable contentSchema;
        [NullAllowed, Export("contentSchema", ArgumentSemantic.Strong)]
        string ContentSchema { get; set; }

        // @property (assign, nonatomic) double quantity;
        [Export("quantity")]
        double Quantity { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * _Nullable price;
        [NullAllowed, Export("price", ArgumentSemantic.Strong)]
        NSDecimalNumber Price { get; set; }

        // @property (nonatomic, strong) BNCCurrency _Nullable currency;
        [NullAllowed, Export("currency", ArgumentSemantic.Strong)]
        string Currency { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable sku;
        [NullAllowed, Export("sku", ArgumentSemantic.Strong)]
        string Sku { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable productName;
        [NullAllowed, Export("productName", ArgumentSemantic.Strong)]
        string ProductName { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable productBrand;
        [NullAllowed, Export("productBrand", ArgumentSemantic.Strong)]
        string ProductBrand { get; set; }

        // @property (nonatomic, strong) BNCProductCategory _Nullable productCategory;
        [NullAllowed, Export("productCategory", ArgumentSemantic.Strong)]
        string ProductCategory { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable productVariant;
        [NullAllowed, Export("productVariant", ArgumentSemantic.Strong)]
        string ProductVariant { get; set; }

        // @property (nonatomic, strong) BranchCondition _Nullable condition;
        [NullAllowed, Export("condition", ArgumentSemantic.Strong)]
        string Condition { get; set; }

        // @property (assign, nonatomic) double ratingAverage;
        [Export("ratingAverage")]
        double RatingAverage { get; set; }

        // @property (assign, nonatomic) NSInteger ratingCount;
        [Export("ratingCount")]
        nint RatingCount { get; set; }

        // @property (assign, nonatomic) double ratingMax;
        [Export("ratingMax")]
        double RatingMax { get; set; }

        // @property (assign, nonatomic) double rating;
        [Export("rating")]
        double Rating { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable addressStreet;
        [NullAllowed, Export("addressStreet", ArgumentSemantic.Strong)]
        string AddressStreet { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable addressCity;
        [NullAllowed, Export("addressCity", ArgumentSemantic.Strong)]
        string AddressCity { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable addressRegion;
        [NullAllowed, Export("addressRegion", ArgumentSemantic.Strong)]
        string AddressRegion { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable addressCountry;
        [NullAllowed, Export("addressCountry", ArgumentSemantic.Strong)]
        string AddressCountry { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable addressPostalCode;
        [NullAllowed, Export("addressPostalCode", ArgumentSemantic.Strong)]
        string AddressPostalCode { get; set; }

        // @property (assign, nonatomic) double latitude;
        [Export("latitude")]
        double Latitude { get; set; }

        // @property (assign, nonatomic) double longitude;
        [Export("longitude")]
        double Longitude { get; set; }

        // @property (copy, nonatomic) NSMutableArray<NSString *> * _Nonnull imageCaptions;
        [Export("imageCaptions", ArgumentSemantic.Copy)]
        NSMutableArray<NSString> ImageCaptions { get; set; }

        // @property (copy, nonatomic) NSMutableDictionary<NSString *,NSString *> * _Nonnull customMetadata;
        [Export("customMetadata", ArgumentSemantic.Copy)]
        NSMutableDictionary<NSString, NSString> CustomMetadata { get; set; }

        // -(NSDictionary * _Nonnull)dictionary;
        [Export("dictionary")]
        //[Verify(MethodToProperty)]
        //NSDictionary Dictionary { get; }
        NSDictionary Dictionary();

        // +(BranchContentMetadata * _Nonnull)contentMetadataWithDictionary:(NSDictionary * _Nullable)dictionary;
        [Static]
        [Export("contentMetadataWithDictionary:")]
        BranchContentMetadata ContentMetadataWithDictionary([NullAllowed] NSDictionary dictionary);
    }

    // @interface BranchUniversalObject : NSObject
    [BaseType(typeof(NSObject))]
    interface BranchUniversalObject
    {
        // -(instancetype _Nonnull)initWithCanonicalIdentifier:(NSString * _Nonnull)canonicalIdentifier;
        [Export("initWithCanonicalIdentifier:")]
        IntPtr Constructor(string canonicalIdentifier);

        //// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title;
        //[Export("initWithTitle:")]
        //IntPtr Constructor(string title);

        // @property (nonatomic, strong) NSString * _Nullable canonicalIdentifier;
        [NullAllowed, Export("canonicalIdentifier", ArgumentSemantic.Strong)]
        string CanonicalIdentifier { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable canonicalUrl;
        [NullAllowed, Export("canonicalUrl", ArgumentSemantic.Strong)]
        string CanonicalUrl { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable title;
        [NullAllowed, Export("title", ArgumentSemantic.Strong)]
        string Title { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable contentDescription;
        [NullAllowed, Export("contentDescription", ArgumentSemantic.Strong)]
        string ContentDescription { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable imageUrl;
        [NullAllowed, Export("imageUrl", ArgumentSemantic.Strong)]
        string ImageUrl { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * _Nullable keywords;
        [NullAllowed, Export("keywords", ArgumentSemantic.Strong)]
        string[] Keywords { get; set; }

        // @property (nonatomic, strong) NSDate * _Nullable creationDate;
        [NullAllowed, Export("creationDate", ArgumentSemantic.Strong)]
        NSDate CreationDate { get; set; }

        // @property (nonatomic, strong) NSDate * _Nullable expirationDate;
        [NullAllowed, Export("expirationDate", ArgumentSemantic.Strong)]
        NSDate ExpirationDate { get; set; }

        // @property (assign, nonatomic) BOOL locallyIndex;
        [Export("locallyIndex")]
        bool LocallyIndex { get; set; }

        // @property (assign, nonatomic) BOOL publiclyIndex;
        [Export("publiclyIndex")]
        bool PubliclyIndex { get; set; }

        // @property (nonatomic, strong) BranchContentMetadata * _Nonnull contentMetadata;
        [Export("contentMetadata", ArgumentSemantic.Strong)]
        BranchContentMetadata ContentMetadata { get; set; }

        // @property (nonatomic, strong) NSDictionary * _Nullable metadata __attribute__((deprecated("Use `BranchUniversalObject.contentMetadata.customMetadata` instead.")));
        [NullAllowed, Export("metadata", ArgumentSemantic.Strong)]
        NSDictionary Metadata { get; set; }

        // -(void)addMetadataKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value __attribute__((deprecated("Use `BranchUniversalObject.contentMetadata.customMetadata` instead.")));
        [Export("addMetadataKey:value:")]
        void AddMetadataKey(string key, string value);

        // @property (nonatomic, strong) NSString * _Nullable type __attribute__((deprecated("Use `BranchUniversalObject.contentMetadata.contentSchema` instead.")));
        [NullAllowed, Export("type", ArgumentSemantic.Strong)]
        string Type { get; set; }

        // @property (assign, nonatomic) BranchContentIndexMode contentIndexMode __attribute__((deprecated("Use `BranchUniversalObject.locallyIndex and BranchUniversalObject.publiclyIndex` instead.")));
        [Export("contentIndexMode", ArgumentSemantic.Assign)]
        BranchContentIndexMode ContentIndexMode { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable spotlightIdentifier __attribute__((deprecated("Not used due to iOS 10.0 Spotlight changes.")));
        [NullAllowed, Export("spotlightIdentifier", ArgumentSemantic.Strong)]
        string SpotlightIdentifier { get; set; }

        // @property (assign, nonatomic) CGFloat price __attribute__((deprecated("Use `BranchUniversalObject.contentMetadata.price` instead.")));
        [Export("price")]
        nfloat Price { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable currency __attribute__((deprecated("Use `BranchUniversalObject.contentMetadata.currency` instead.")));
        [NullAllowed, Export("currency", ArgumentSemantic.Strong)]
        string Currency { get; set; }

        // @property (assign, nonatomic) BOOL automaticallyListOnSpotlight __attribute__((deprecated("Use `BranchUniversalObject.locallyIndex` instead.")));
        [Export("automaticallyListOnSpotlight")]
        bool AutomaticallyListOnSpotlight { get; set; }

        // -(void)registerView;
        [Export("registerView")]
        void RegisterView();

        // -(void)registerViewWithCallback:(void (^ _Nullable)(NSDictionary * _Nullable, NSError * _Nullable))callback;
        [Export("registerViewWithCallback:")]
        void RegisterViewWithCallback([NullAllowed] Action<NSDictionary, NSError> callback);

        // -(void)userCompletedAction:(NSString * _Nonnull)action;
        [Export("userCompletedAction:")]
        void UserCompletedAction(string action);

        // -(void)userCompletedAction:(NSString * _Nonnull)action withState:(NSDictionary * _Nullable)state;
        [Export("userCompletedAction:withState:")]
        void UserCompletedAction(string action, [NullAllowed] NSDictionary state);

        // -(NSString * _Nullable)getShortUrlWithLinkProperties:(BranchLinkProperties * _Nonnull)linkProperties;
        [Export("getShortUrlWithLinkProperties:")]
        [return: NullAllowed]
        string GetShortUrlWithLinkProperties(BranchLinkProperties linkProperties);

        // -(NSString * _Nullable)getShortUrlWithLinkPropertiesAndIgnoreFirstClick:(BranchLinkProperties * _Nonnull)linkProperties;
        [Export("getShortUrlWithLinkPropertiesAndIgnoreFirstClick:")]
        [return: NullAllowed]
        string GetShortUrlWithLinkPropertiesAndIgnoreFirstClick(BranchLinkProperties linkProperties);

        // -(void)getShortUrlWithLinkProperties:(BranchLinkProperties * _Nonnull)linkProperties andCallback:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))callback;
        [Export("getShortUrlWithLinkProperties:andCallback:")]
        void GetShortUrlWithLinkProperties(BranchLinkProperties linkProperties, [NullAllowed] Action<string, NSError> callback);

        // -(NSString * _Nullable)getLongUrlWithChannel:(NSString * _Nullable)channel andTags:(NSArray * _Nullable)tags andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andAlias:(NSString * _Nullable)alias;
        [Export("getLongUrlWithChannel:andTags:andFeature:andStage:andAlias:")]
        //[Verify(StronglyTypedNSArray)]
        [return: NullAllowed]
        string GetLongUrlWithChannel([NullAllowed] string channel, [NullAllowed] NSObject[] tags, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string alias);

        // -(UIActivityItemProvider * _Nullable)getBranchActivityItemWithLinkProperties:(BranchLinkProperties * _Nonnull)linkProperties;
        [Export("getBranchActivityItemWithLinkProperties:")]
        [return: NullAllowed]
        UIActivityItemProvider GetBranchActivityItemWithLinkProperties(BranchLinkProperties linkProperties);

        // -(void)showShareSheetWithShareText:(NSString * _Nullable)shareText completion:(void (^ _Nullable)(NSString * _Nullable, BOOL))completion;
        [Export("showShareSheetWithShareText:completion:")]
        void ShowShareSheetWithShareText([NullAllowed] string shareText, [NullAllowed] Action<NSString, bool> completion);

        // -(void)showShareSheetWithLinkProperties:(BranchLinkProperties * _Nullable)linkProperties andShareText:(NSString * _Nullable)shareText fromViewController:(UIViewController * _Nullable)viewController completion:(void (^ _Nullable)(NSString * _Nullable, BOOL))completion;
        [Export("showShareSheetWithLinkProperties:andShareText:fromViewController:completion:")]
        void ShowShareSheetWithLinkProperties([NullAllowed] BranchLinkProperties linkProperties, [NullAllowed] string shareText, [NullAllowed] UIViewController viewController, [NullAllowed] Action<string, bool> completion);

        // -(void)showShareSheetWithLinkProperties:(BranchLinkProperties * _Nullable)linkProperties andShareText:(NSString * _Nullable)shareText fromViewController:(UIViewController * _Nullable)viewController completionWithError:(void (^ _Nullable)(NSString * _Nullable, BOOL, NSError * _Nullable))completion;
        [Export("showShareSheetWithLinkProperties:andShareText:fromViewController:completionWithError:")]
        void ShowShareSheetWithLinkProperties([NullAllowed] BranchLinkProperties linkProperties, [NullAllowed] string shareText, [NullAllowed] UIViewController viewController, [NullAllowed] Action<string, bool, NSError> completion);

        // -(void)showShareSheetWithLinkProperties:(BranchLinkProperties * _Nullable)linkProperties andShareText:(NSString * _Nullable)shareText fromViewController:(UIViewController * _Nullable)viewController anchor:(UIBarButtonItem * _Nullable)anchor completion:(void (^ _Nullable)(NSString * _Nullable, BOOL))completion;
        [Export("showShareSheetWithLinkProperties:andShareText:fromViewController:anchor:completion:")]
        void ShowShareSheetWithLinkProperties([NullAllowed] BranchLinkProperties linkProperties, [NullAllowed] string shareText, [NullAllowed] UIViewController viewController, [NullAllowed] UIBarButtonItem anchor, [NullAllowed] Action<string, bool> completion);

        // -(void)showShareSheetWithLinkProperties:(BranchLinkProperties * _Nullable)linkProperties andShareText:(NSString * _Nullable)shareText fromViewController:(UIViewController * _Nullable)viewController anchor:(UIBarButtonItem * _Nullable)anchor completionWithError:(void (^ _Nullable)(NSString * _Nullable, BOOL, NSError * _Nullable))completion;
        [Export("showShareSheetWithLinkProperties:andShareText:fromViewController:anchor:completionWithError:")]
        void ShowShareSheetWithLinkProperties([NullAllowed] BranchLinkProperties linkProperties, [NullAllowed] string shareText, [NullAllowed] UIViewController viewController, [NullAllowed] UIBarButtonItem anchor, [NullAllowed] Action<string, bool, NSError> completion);

        // -(void)listOnSpotlight;
        [Export("listOnSpotlight")]
        void ListOnSpotlight();

        // -(void)listOnSpotlightWithCallback:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))callback;
        [Export("listOnSpotlightWithCallback:")]
        void ListOnSpotlightWithCallback([NullAllowed] Action<NSString, NSError> callback);

        // -(void)listOnSpotlightWithIdentifierCallback:(void (^ _Nullable)(NSString * _Nullable, NSString * _Nullable, NSError * _Nullable))spotlightCallback __attribute__((deprecated("iOS 10 has changed how Spotlight indexing works and we’ve updated the SDK to reflect this. Please see https://dev.branch.io/features/spotlight-indexing/overview/ for instructions on migration.")));
        [Export("listOnSpotlightWithIdentifierCallback:")]
        void ListOnSpotlightWithIdentifierCallback([NullAllowed] Action<NSString, NSString, NSError> spotlightCallback);

        // -(void)listOnSpotlightWithLinkProperties:(BranchLinkProperties * _Nullable)linkproperties callback:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
        [Export("listOnSpotlightWithLinkProperties:callback:")]
        void ListOnSpotlightWithLinkProperties([NullAllowed] BranchLinkProperties linkproperties, [NullAllowed] Action<NSString, NSError> completion);

        // -(void)removeFromSpotlightWithCallback:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("removeFromSpotlightWithCallback:")]
        void RemoveFromSpotlightWithCallback([NullAllowed] Action<NSError> completion);

        // -(NSDictionary * _Nonnull)getDictionaryWithCompleteLinkProperties:(BranchLinkProperties * _Nonnull)linkProperties;
        [Export("getDictionaryWithCompleteLinkProperties:")]
        NSDictionary GetDictionaryWithCompleteLinkProperties(BranchLinkProperties linkProperties);

        // -(NSDictionary * _Nonnull)getParamsForServerRequestWithAddedLinkProperties:(BranchLinkProperties * _Nonnull)linkProperties;
        [Export("getParamsForServerRequestWithAddedLinkProperties:")]
        NSDictionary GetParamsForServerRequestWithAddedLinkProperties(BranchLinkProperties linkProperties);

        // -(NSMutableDictionary * _Nonnull)dictionary;
        [Export("dictionary")]
        //[Verify(MethodToProperty)]
        //NSMutableDictionary Dictionary { get; }
        NSMutableDictionary Dictionary();

        // +(BranchUniversalObject * _Nonnull)objectWithDictionary:(NSDictionary * _Null_unspecified)dictionary;
        [Static]
        [Export("objectWithDictionary:")]
        BranchUniversalObject ObjectWithDictionary(NSDictionary dictionary);

        //// -(NSString * _Nonnull)description;
        //[Export("description")]
        //[Verify(MethodToProperty)]
        //string Description { get; }
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern BranchStandardEvent _Nonnull BranchStandardEventAddToCart;
        [Field("BranchStandardEventAddToCart", "__Internal")]
        NSString BranchStandardEventAddToCart { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventAddToWishlist;
        [Field("BranchStandardEventAddToWishlist", "__Internal")]
        NSString BranchStandardEventAddToWishlist { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventViewCart;
        [Field("BranchStandardEventViewCart", "__Internal")]
        NSString BranchStandardEventViewCart { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventInitiatePurchase;
        [Field("BranchStandardEventInitiatePurchase", "__Internal")]
        NSString BranchStandardEventInitiatePurchase { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventAddPaymentInfo;
        [Field("BranchStandardEventAddPaymentInfo", "__Internal")]
        NSString BranchStandardEventAddPaymentInfo { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventPurchase;
        [Field("BranchStandardEventPurchase", "__Internal")]
        NSString BranchStandardEventPurchase { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventSubscribe;
        [Field("BranchStandardEventSubscribe", "__Internal")]
        NSString BranchStandardEventSubscribe { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventStartTrial;
        [Field("BranchStandardEventStartTrial", "__Internal")]
        NSString BranchStandardEventStartTrial { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventClickAd;
        [Field("BranchStandardEventClickAd", "__Internal")]
        NSString BranchStandardEventClickAd { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventViewAd;
        [Field("BranchStandardEventViewAd", "__Internal")]
        NSString BranchStandardEventViewAd { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventSearch;
        [Field("BranchStandardEventSearch", "__Internal")]
        NSString BranchStandardEventSearch { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventViewItem;
        [Field("BranchStandardEventViewItem", "__Internal")]
        NSString BranchStandardEventViewItem { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventViewItems;
        [Field("BranchStandardEventViewItems", "__Internal")]
        NSString BranchStandardEventViewItems { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventRate;
        [Field("BranchStandardEventRate", "__Internal")]
        NSString BranchStandardEventRate { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventShare;
        [Field("BranchStandardEventShare", "__Internal")]
        NSString BranchStandardEventShare { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventInitiateStream;
        [Field("BranchStandardEventInitiateStream", "__Internal")]
        NSString BranchStandardEventInitiateStream { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventCompleteStream;
        [Field("BranchStandardEventCompleteStream", "__Internal")]
        NSString BranchStandardEventCompleteStream { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventCompleteRegistration;
        [Field("BranchStandardEventCompleteRegistration", "__Internal")]
        NSString BranchStandardEventCompleteRegistration { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventCompleteTutorial;
        [Field("BranchStandardEventCompleteTutorial", "__Internal")]
        NSString BranchStandardEventCompleteTutorial { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventAchieveLevel;
        [Field("BranchStandardEventAchieveLevel", "__Internal")]
        NSString BranchStandardEventAchieveLevel { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventUnlockAchievement;
        [Field("BranchStandardEventUnlockAchievement", "__Internal")]
        NSString BranchStandardEventUnlockAchievement { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventInvite;
        [Field("BranchStandardEventInvite", "__Internal")]
        NSString BranchStandardEventInvite { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventLogin;
        [Field("BranchStandardEventLogin", "__Internal")]
        NSString BranchStandardEventLogin { get; }

        // extern BranchStandardEvent _Nonnull BranchStandardEventReserve;
        [Field("BranchStandardEventReserve", "__Internal")]
        NSString BranchStandardEventReserve { get; }
    }

    // @interface BranchEvent : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BranchEvent
    {
        // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name __attribute__((objc_designated_initializer));
        [Export("initWithName:")]
        [DesignatedInitializer]
        IntPtr Constructor(string name);

        // +(instancetype _Nonnull)standardEvent:(BranchStandardEvent _Nonnull)standardEvent;
        [Static]
        [Export("standardEvent:")]
        BranchEvent StandardEvent(string standardEvent);

        // +(instancetype _Nonnull)standardEvent:(BranchStandardEvent _Nonnull)standardEvent withContentItem:(BranchUniversalObject * _Nonnull)contentItem;
        [Static]
        [Export("standardEvent:withContentItem:")]
        BranchEvent StandardEvent(string standardEvent, BranchUniversalObject contentItem);

        // +(instancetype _Nonnull)customEventWithName:(NSString * _Nonnull)name;
        [Static]
        [Export("customEventWithName:")]
        BranchEvent CustomEventWithName(string name);

        // +(instancetype _Nonnull)customEventWithName:(NSString * _Nonnull)name contentItem:(BranchUniversalObject * _Nonnull)contentItem;
        [Static]
        [Export("customEventWithName:contentItem:")]
        BranchEvent CustomEventWithName(string name, BranchUniversalObject contentItem);

        // @property (nonatomic, strong) NSString * _Nullable alias;
        [NullAllowed, Export("alias", ArgumentSemantic.Strong)]
        string Alias { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable transactionID;
        [NullAllowed, Export("transactionID", ArgumentSemantic.Strong)]
        string TransactionID { get; set; }

        // @property (nonatomic, strong) BNCCurrency _Nullable currency;
        [NullAllowed, Export("currency", ArgumentSemantic.Strong)]
        string Currency { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * _Nullable revenue;
        [NullAllowed, Export("revenue", ArgumentSemantic.Strong)]
        NSDecimalNumber Revenue { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * _Nullable shipping;
        [NullAllowed, Export("shipping", ArgumentSemantic.Strong)]
        NSDecimalNumber Shipping { get; set; }

        // @property (nonatomic, strong) NSDecimalNumber * _Nullable tax;
        [NullAllowed, Export("tax", ArgumentSemantic.Strong)]
        NSDecimalNumber Tax { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable coupon;
        [NullAllowed, Export("coupon", ArgumentSemantic.Strong)]
        string Coupon { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable affiliation;
        [NullAllowed, Export("affiliation", ArgumentSemantic.Strong)]
        string Affiliation { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable eventDescription;
        [NullAllowed, Export("eventDescription", ArgumentSemantic.Strong)]
        string EventDescription { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable searchQuery;
        [NullAllowed, Export("searchQuery", ArgumentSemantic.Strong)]
        string SearchQuery { get; set; }

        // @property (assign, nonatomic) BranchEventAdType adType;
        [Export("adType", ArgumentSemantic.Assign)]
        BranchEventAdType AdType { get; set; }

        // @property (copy, nonatomic) NSArray<BranchUniversalObject *> * _Nonnull contentItems;
        [Export("contentItems", ArgumentSemantic.Strong)]
        //BranchUniversalObject[] ContentItems { get; set; }
        NSArray ContentItems { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull customData;
        [Export("customData", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSString> CustomData { get; set; }

        // -(void)logEvent;
        [Export("logEvent")]
        void LogEvent();

        // -(NSDictionary * _Nonnull)dictionary;
        [Export("dictionary")]
        //[Verify(MethodToProperty)]
        //NSDictionary Dictionary { get; }
        NSDictionary Dictionary();

        //// -(NSString * _Nonnull)description;
        //[Export("description")]
        //[Verify(MethodToProperty)]
        //string Description { get; }
    }

    // @interface BranchEventRequest : BNCServerRequest <NSSecureCoding>
    [BaseType(typeof(BNCServerRequest))]
    interface BranchEventRequest : INSSecureCoding
    {
        // -(instancetype _Nonnull)initWithServerURL:(NSURL * _Nonnull)serverURL eventDictionary:(NSDictionary * _Nullable)eventDictionary completion:(void (^ _Nullable)(NSDictionary * _Nullable, NSError * _Nullable))completion;
        [Export("initWithServerURL:eventDictionary:completion:")]
        IntPtr Constructor(NSUrl serverURL, [NullAllowed] NSDictionary eventDictionary, [NullAllowed] Action<NSDictionary, NSError> completion);

        // @property (strong) NSDictionary * _Nullable eventDictionary;
        [NullAllowed, Export("eventDictionary", ArgumentSemantic.Strong)]
        NSDictionary EventDictionary { get; set; }

        // @property (strong) NSURL * _Nullable serverURL;
        [NullAllowed, Export("serverURL", ArgumentSemantic.Strong)]
        NSUrl ServerURL { get; set; }

        // @property (copy) void (^ _Nullable)(NSDictionary * _Nullable, NSError * _Nullable) completion;
        [NullAllowed, Export("completion", ArgumentSemantic.Copy)]
        Action<NSDictionary, NSError> Completion { get; set; }
    }

    // @interface BranchLinkProperties : NSObject
    [BaseType(typeof(NSObject))]
    interface BranchLinkProperties
    {
        // @property (nonatomic, strong) NSArray * tags;
        [Export("tags", ArgumentSemantic.Strong)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] Tags { get; set; }

        // @property (nonatomic, strong) NSString * feature;
        [Export("feature", ArgumentSemantic.Strong)]
        string Feature { get; set; }

        // @property (nonatomic, strong) NSString * alias;
        [Export("alias", ArgumentSemantic.Strong)]
        string Alias { get; set; }

        // @property (nonatomic, strong) NSString * channel;
        [Export("channel", ArgumentSemantic.Strong)]
        string Channel { get; set; }

        // @property (nonatomic, strong) NSString * stage;
        [Export("stage", ArgumentSemantic.Strong)]
        string Stage { get; set; }

        // @property (nonatomic, strong) NSString * campaign;
        [Export("campaign", ArgumentSemantic.Strong)]
        string Campaign { get; set; }

        // @property (nonatomic) NSUInteger matchDuration;
        [Export("matchDuration")]
        nuint MatchDuration { get; set; }

        // @property (nonatomic, strong) NSDictionary * controlParams;
        [Export("controlParams", ArgumentSemantic.Strong)]
        NSDictionary ControlParams { get; set; }

        // -(void)addControlParam:(NSString *)controlParam withValue:(NSString *)value;
        [Export("addControlParam:withValue:")]
        void AddControlParam(string controlParam, string value);

        // +(BranchLinkProperties *)getBranchLinkPropertiesFromDictionary:(NSDictionary *)dictionary;
        [Static]
        [Export("getBranchLinkPropertiesFromDictionary:")]
        BranchLinkProperties GetBranchLinkPropertiesFromDictionary(NSDictionary dictionary);

        //// -(NSString *)description;
        //[Export("description")]
        //[Verify(MethodToProperty)]
        //string Description { get; }
    }

    // @protocol BranchDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface BranchDelegate
    {
        // @optional -(void)branch:(Branch * _Nonnull)branch willStartSessionWithURL:(NSURL * _Nullable)url;
        [Export("branch:willStartSessionWithURL:")]
        void WillStartSessionWithURL(Branch branch, [NullAllowed] NSUrl url);

        // @optional -(void)branch:(Branch * _Nonnull)branch didStartSessionWithURL:(NSURL * _Nullable)url branchLink:(BranchLink * _Nullable)branchLink;
        [Export("branch:didStartSessionWithURL:branchLink:")]
        void DidStartSessionWithURL(Branch branch, [NullAllowed] NSUrl url, [NullAllowed] BranchLink branchLink);

        // @optional -(void)branch:(Branch * _Nonnull)branch failedToStartSessionWithURL:(NSURL * _Nullable)url error:(NSError * _Nullable)error;
        [Export("branch:failedToStartSessionWithURL:error:")]
        void FailedToStartSessionWithURL(Branch branch, [NullAllowed] NSUrl url, [NullAllowed] NSError error);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull BranchWillStartSessionNotification;
        [Field("BranchWillStartSessionNotification", "__Internal")]
        NSString BranchWillStartSessionNotification { get; }

        // extern NSString *const _Nonnull BranchDidStartSessionNotification;
        [Field("BranchDidStartSessionNotification", "__Internal")]
        NSString BranchDidStartSessionNotification { get; }

        // extern NSString *const _Nonnull BranchErrorKey;
        [Field("BranchErrorKey", "__Internal")]
        NSString BranchErrorKey { get; }

        // extern NSString *const _Nonnull BranchURLKey;
        [Field("BranchURLKey", "__Internal")]
        NSString BranchURLKey { get; }

        // extern NSString *const _Nonnull BranchUniversalObjectKey;
        [Field("BranchUniversalObjectKey", "__Internal")]
        NSString BranchUniversalObjectKey { get; }

        // extern NSString *const _Nonnull BranchLinkPropertiesKey;
        [Field("BranchLinkPropertiesKey", "__Internal")]
        NSString BranchLinkPropertiesKey { get; }
    }

    // @protocol BranchShareLinkDelegate <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface BranchShareLinkDelegate
    {
        // @optional -(void)branchShareLinkWillShare:(BranchShareLink * _Nonnull)shareLink;
        [Export("branchShareLinkWillShare:")]
        void BranchShareLinkWillShare(BranchShareLink shareLink);

        // @optional -(void)branchShareLink:(BranchShareLink * _Nonnull)shareLink didComplete:(BOOL)completed withError:(NSError * _Nullable)error;
        [Export("branchShareLink:didComplete:withError:")]
        void BranchShareLink(BranchShareLink shareLink, bool completed, [NullAllowed] NSError error);
    }

    // @interface BranchShareLink : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface BranchShareLink
    {
        // -(instancetype _Nonnull)initWithUniversalObject:(BranchUniversalObject * _Nonnull)universalObject linkProperties:(BranchLinkProperties * _Nonnull)linkProperties __attribute__((objc_designated_initializer));
        [Export("initWithUniversalObject:linkProperties:")]
        [DesignatedInitializer]
        IntPtr Constructor(BranchUniversalObject universalObject, BranchLinkProperties linkProperties);

        // -(NSArray<UIActivityItemProvider *> * _Nonnull)activityItems;
        [Export("activityItems")]
        //[Verify(MethodToProperty)]
        UIActivityItemProvider[] ActivityItems { get; }

        // -(void)presentActivityViewControllerFromViewController:(UIViewController * _Nullable)viewController anchor:(id _Nullable)anchorViewOrButtonItem;
        [Export("presentActivityViewControllerFromViewController:anchor:")]
        void PresentActivityViewControllerFromViewController([NullAllowed] UIViewController viewController, [NullAllowed] NSObject anchorViewOrButtonItem);

        // @property (nonatomic, strong) NSString * _Nullable title;
        [NullAllowed, Export("title", ArgumentSemantic.Strong)]
        string Title { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable shareText;
        [NullAllowed, Export("shareText", ArgumentSemantic.Strong)]
        string ShareText { get; set; }

        // @property (nonatomic, strong) id _Nullable shareObject;
        [NullAllowed, Export("shareObject", ArgumentSemantic.Strong)]
        NSObject ShareObject { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable emailSubject;
        [NullAllowed, Export("emailSubject", ArgumentSemantic.Strong)]
        string EmailSubject { get; set; }

        // @property (readonly, nonatomic, strong) NSURL * _Nullable shareURL;
        [NullAllowed, Export("shareURL", ArgumentSemantic.Strong)]
        NSUrl ShareURL { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable activityType;
        [NullAllowed, Export("activityType", ArgumentSemantic.Strong)]
        string ActivityType { get; }

        // @property (nonatomic, strong) NSMutableDictionary * _Nullable serverParameters;
        [NullAllowed, Export("serverParameters", ArgumentSemantic.Strong)]
        NSMutableDictionary ServerParameters { get; set; }

        // @property (readonly, nonatomic, strong) BranchUniversalObject * _Nonnull universalObject;
        [Export("universalObject", ArgumentSemantic.Strong)]
        BranchUniversalObject UniversalObject { get; }

        // @property (readonly, nonatomic, strong) BranchLinkProperties * _Nonnull linkProperties;
        [Export("linkProperties", ArgumentSemantic.Strong)]
        BranchLinkProperties LinkProperties { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        BranchShareLinkDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<BranchShareLinkDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }
    }

    // @interface BranchProbabilisticCrossPlatformID : NSObject
    [BaseType(typeof(NSObject))]
    interface BranchProbabilisticCrossPlatformID
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull crossPlatformID;
        [Export("crossPlatformID")]
        string CrossPlatformID { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nonnull score;
        [Export("score", ArgumentSemantic.Copy)]
        NSNumber Score { get; }

        // +(BranchProbabilisticCrossPlatformID * _Nullable)buildFromJSON:(NSDictionary * _Nonnull)json;
        [Static]
        [Export("buildFromJSON:")]
        [return: NullAllowed]
        BranchProbabilisticCrossPlatformID BuildFromJSON(NSDictionary json);
    }

    // @interface BranchCrossPlatformID : NSObject
    [BaseType(typeof(NSObject))]
    interface BranchCrossPlatformID
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull crossPlatformID;
        [Export("crossPlatformID")]
        string CrossPlatformID { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull developerID;
        [Export("developerID")]
        string DeveloperID { get; }

        // @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nonnull pastCrossPlatformIDs;
        [Export("pastCrossPlatformIDs", ArgumentSemantic.Strong)]
        string[] PastCrossPlatformIDs { get; }

        // @property (readonly, nonatomic, strong) NSArray<BranchProbabilisticCrossPlatformID *> * _Nonnull probabiliticCrossPlatformIDs;
        [Export("probabiliticCrossPlatformIDs", ArgumentSemantic.Strong)]
        BranchProbabilisticCrossPlatformID[] ProbabiliticCrossPlatformIDs { get; }

        // +(BranchCrossPlatformID * _Nullable)buildFromJSON:(NSDictionary * _Nonnull)json;
        [Static]
        [Export("buildFromJSON:")]
        [return: NullAllowed]
        BranchCrossPlatformID BuildFromJSON(NSDictionary json);

        // +(void)requestCrossPlatformIdData:(BNCServerInterface * _Nonnull)serverInterface key:(NSString * _Nonnull)key completion:(void (^ _Nonnull)(BranchCrossPlatformID * _Nullable))completion;
        [Static]
        [Export("requestCrossPlatformIdData:key:completion:")]
        void RequestCrossPlatformIdData(BNCServerInterface serverInterface, string key, Action<BranchCrossPlatformID> completion);
    }

    // @interface BranchLastAttributedTouchData : NSObject
    [BaseType(typeof(NSObject))]
    interface BranchLastAttributedTouchData
    {
        // @property (readonly, nonatomic, strong) NSDictionary * _Nonnull lastAttributedTouchJSON;
        [Export("lastAttributedTouchJSON", ArgumentSemantic.Strong)]
        NSDictionary LastAttributedTouchJSON { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nonnull attributionWindow;
        [Export("attributionWindow", ArgumentSemantic.Copy)]
        NSNumber AttributionWindow { get; }

        // +(BranchLastAttributedTouchData * _Nullable)buildFromJSON:(NSDictionary * _Nonnull)json;
        [Static]
        [Export("buildFromJSON:")]
        [return: NullAllowed]
        BranchLastAttributedTouchData BuildFromJSON(NSDictionary json);

        // +(void)requestLastTouchAttributedData:(BNCServerInterface * _Nonnull)serverInterface key:(NSString * _Nonnull)key attributionWindow:(NSInteger)window completion:(void (^ _Nonnull)(BranchLastAttributedTouchData * _Nonnull))completion;
        [Static]
        [Export("requestLastTouchAttributedData:key:attributionWindow:completion:")]
        void RequestLastTouchAttributedData(BNCServerInterface serverInterface, string key, nint window, Action<BranchLastAttributedTouchData> completion);
    }

    // @interface Branch (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_Branch
    {
        // +(UIWindow * _Nullable)bnc_currentWindow;
        [Static]
        [NullAllowed, Export("bnc_currentWindow")]
        //[Verify(MethodToProperty)]
        UIWindow Bnc_currentWindow { get; }

        // +(UIViewController * _Nullable)bnc_currentViewController;
        [Static]
        [NullAllowed, Export("bnc_currentViewController")]
        //[Verify(MethodToProperty)]
        UIViewController Bnc_currentViewController { get; }

        //// -(UIViewController * _Nonnull)bnc_currentViewController;
        //[Export("bnc_currentViewController")]
        //[Verify(MethodToProperty)]
        //UIViewController Bnc_currentViewController { get; }
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull BRANCH_FEATURE_TAG_SHARE;
        [Field("BRANCH_FEATURE_TAG_SHARE", "__Internal")]
        NSString BRANCH_FEATURE_TAG_SHARE { get; }

        // extern NSString *const _Nonnull BRANCH_FEATURE_TAG_REFERRAL;
        [Field("BRANCH_FEATURE_TAG_REFERRAL", "__Internal")]
        NSString BRANCH_FEATURE_TAG_REFERRAL { get; }

        // extern NSString *const _Nonnull BRANCH_FEATURE_TAG_INVITE;
        [Field("BRANCH_FEATURE_TAG_INVITE", "__Internal")]
        NSString BRANCH_FEATURE_TAG_INVITE { get; }

        // extern NSString *const _Nonnull BRANCH_FEATURE_TAG_DEAL;
        [Field("BRANCH_FEATURE_TAG_DEAL", "__Internal")]
        NSString BRANCH_FEATURE_TAG_DEAL { get; }

        // extern NSString *const _Nonnull BRANCH_FEATURE_TAG_GIFT;
        [Field("BRANCH_FEATURE_TAG_GIFT", "__Internal")]
        NSString BRANCH_FEATURE_TAG_GIFT { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_CHANNEL;
        [Field("BRANCH_INIT_KEY_CHANNEL", "__Internal")]
        NSString BRANCH_INIT_KEY_CHANNEL { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_FEATURE;
        [Field("BRANCH_INIT_KEY_FEATURE", "__Internal")]
        NSString BRANCH_INIT_KEY_FEATURE { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_TAGS;
        [Field("BRANCH_INIT_KEY_TAGS", "__Internal")]
        NSString BRANCH_INIT_KEY_TAGS { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_CAMPAIGN;
        [Field("BRANCH_INIT_KEY_CAMPAIGN", "__Internal")]
        NSString BRANCH_INIT_KEY_CAMPAIGN { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_STAGE;
        [Field("BRANCH_INIT_KEY_STAGE", "__Internal")]
        NSString BRANCH_INIT_KEY_STAGE { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_CREATION_SOURCE;
        [Field("BRANCH_INIT_KEY_CREATION_SOURCE", "__Internal")]
        NSString BRANCH_INIT_KEY_CREATION_SOURCE { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_REFERRER;
        [Field("BRANCH_INIT_KEY_REFERRER", "__Internal")]
        NSString BRANCH_INIT_KEY_REFERRER { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_PHONE_NUMBER;
        [Field("BRANCH_INIT_KEY_PHONE_NUMBER", "__Internal")]
        NSString BRANCH_INIT_KEY_PHONE_NUMBER { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_IS_FIRST_SESSION;
        [Field("BRANCH_INIT_KEY_IS_FIRST_SESSION", "__Internal")]
        NSString BRANCH_INIT_KEY_IS_FIRST_SESSION { get; }

        // extern NSString *const _Nonnull BRANCH_INIT_KEY_CLICKED_BRANCH_LINK;
        [Field("BRANCH_INIT_KEY_CLICKED_BRANCH_LINK", "__Internal")]
        NSString BRANCH_INIT_KEY_CLICKED_BRANCH_LINK { get; }

        // extern NSString *const _Nonnull BNCCanonicalIdList;
        [Field("BNCCanonicalIdList", "__Internal")]
        NSString BNCCanonicalIdList { get; }

        // extern NSString *const _Nonnull BNCPurchaseAmount;
        [Field("BNCPurchaseAmount", "__Internal")]
        NSString BNCPurchaseAmount { get; }

        // extern NSString *const _Nonnull BNCPurchaseCurrency;
        [Field("BNCPurchaseCurrency", "__Internal")]
        NSString BNCPurchaseCurrency { get; }

        //// extern NSString *const _Nonnull BNCCanonicalIdList;
        //[Field("BNCCanonicalIdList", "__Internal")]
        //NSString BNCCanonicalIdList { get; }

        // extern NSString *const _Nonnull BNCRegisterViewEvent;
        [Field("BNCRegisterViewEvent", "__Internal")]
        NSString BNCRegisterViewEvent { get; }

        // extern NSString *const _Nonnull BNCAddToWishlistEvent;
        [Field("BNCAddToWishlistEvent", "__Internal")]
        NSString BNCAddToWishlistEvent { get; }

        // extern NSString *const _Nonnull BNCAddToCartEvent;
        [Field("BNCAddToCartEvent", "__Internal")]
        NSString BNCAddToCartEvent { get; }

        // extern NSString *const _Nonnull BNCPurchaseInitiatedEvent;
        [Field("BNCPurchaseInitiatedEvent", "__Internal")]
        NSString BNCPurchaseInitiatedEvent { get; }

        // extern NSString *const _Nonnull BNCPurchasedEvent;
        [Field("BNCPurchasedEvent", "__Internal")]
        NSString BNCPurchasedEvent { get; }

        // extern NSString *const _Nonnull BNCShareInitiatedEvent;
        [Field("BNCShareInitiatedEvent", "__Internal")]
        NSString BNCShareInitiatedEvent { get; }

        // extern NSString *const _Nonnull BNCShareCompletedEvent;
        [Field("BNCShareCompletedEvent", "__Internal")]
        NSString BNCShareCompletedEvent { get; }

        // extern NSString *const _Nonnull BNCSpotlightFeature;
        [Field("BNCSpotlightFeature", "__Internal")]
        NSString BNCSpotlightFeature { get; }
    }

    // @interface BranchLink : NSObject
    [BaseType(typeof(NSObject))]
    interface BranchLink
    {
        // @property (nonatomic, strong) BranchUniversalObject * _Nullable universalObject;
        [NullAllowed, Export("universalObject", ArgumentSemantic.Strong)]
        BranchUniversalObject UniversalObject { get; set; }

        // @property (nonatomic, strong) BranchLinkProperties * _Nullable linkProperties;
        [NullAllowed, Export("linkProperties", ArgumentSemantic.Strong)]
        BranchLinkProperties LinkProperties { get; set; }

        // +(BranchLink * _Nullable)linkWithUniversalObject:(BranchUniversalObject * _Nullable)universalObject properties:(BranchLinkProperties * _Nullable)linkProperties;
        [Static]
        [Export("linkWithUniversalObject:properties:")]
        [return: NullAllowed]
        BranchLink LinkWithUniversalObject([NullAllowed] BranchUniversalObject universalObject, [NullAllowed] BranchLinkProperties linkProperties);
    }

    // @interface Branch : NSObject
    [BaseType(typeof(NSObject))]
    interface Branch
    {
        // +(Branch * _Nonnull)getTestInstance __attribute__((deprecated("Use `Branch.useTestBranchKey = YES;` instead.")));
        [Static]
        [Export("getTestInstance")]
        //[Verify(MethodToProperty)]
        Branch TestInstance { get; }

        // +(Branch * _Nonnull)getInstance;
        [Static]
        [Export("getInstance")]
        //[Verify(MethodToProperty)]
        Branch Instance { get; }

        // +(Branch * _Nonnull)getInstance:(NSString * _Nonnull)branchKey;
        [Static]
        [Export("getInstance:")]
        Branch GetInstance(string branchKey);

        // +(Class _Nonnull)networkServiceClass;
        // +(void)setNetworkServiceClass:(Class _Nonnull)networkServiceClass;
        [Static]
        [Export("networkServiceClass")]
        //[Verify(MethodToProperty)]
        Class NetworkServiceClass { get; set; }

        // +(BOOL)useTestBranchKey;
        // +(void)setUseTestBranchKey:(BOOL)useTestKey;
        [Static]
        [Export("useTestBranchKey")]
        //[Verify(MethodToProperty)]
        bool UseTestBranchKey { get; set; }

        // +(void)setBranchKey:(NSString * _Nonnull)branchKey error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("setBranchKey:error:")]
        void SetBranchKey(string branchKey, [NullAllowed] out NSError error);

        // +(NSString * _Nullable)branchKey;
        // +(void)setBranchKey:(NSString * _Nonnull)branchKey;
        [Static]
        [NullAllowed, Export("branchKey")]
        //[Verify(MethodToProperty)]
        string BranchKey { get; set; }

        // +(BOOL)branchKeyIsSet;
        [Static]
        [Export("branchKeyIsSet")]
        //[Verify(MethodToProperty)]
        bool BranchKeyIsSet { get; }

        // +(BOOL)enableFingerprintIDInCrashlyticsReports;
        // +(void)setEnableFingerprintIDInCrashlyticsReports:(BOOL)enabled;
        [Static]
        [Export("enableFingerprintIDInCrashlyticsReports")]
        //[Verify(MethodToProperty)]
        bool EnableFingerprintIDInCrashlyticsReports { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        BranchDelegate Delegate { get; set; }

        // @property (weak) NSObject<BranchDelegate> * _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // +(BranchActivityItemProvider * _Nonnull)getBranchActivityItemWithParams:(NSDictionary * _Nonnull)params;
        [Static]
        [Export("getBranchActivityItemWithParams:")]
        BranchActivityItemProvider GetBranchActivityItemWithParams(NSDictionary @params);

        // +(BranchActivityItemProvider * _Nonnull)getBranchActivityItemWithParams:(NSDictionary * _Nonnull)params feature:(NSString * _Nullable)feature;
        [Static]
        [Export("getBranchActivityItemWithParams:feature:")]
        BranchActivityItemProvider GetBranchActivityItemWithParams(NSDictionary @params, [NullAllowed] string feature);

        // +(BranchActivityItemProvider * _Nonnull)getBranchActivityItemWithParams:(NSDictionary * _Nonnull)params feature:(NSString * _Nullable)feature stage:(NSString * _Nullable)stage;
        [Static]
        [Export("getBranchActivityItemWithParams:feature:stage:")]
        BranchActivityItemProvider GetBranchActivityItemWithParams(NSDictionary @params, [NullAllowed] string feature, [NullAllowed] string stage);

        // +(BranchActivityItemProvider * _Nonnull)getBranchActivityItemWithParams:(NSDictionary * _Nonnull)params feature:(NSString * _Nullable)feature stage:(NSString * _Nullable)stage tags:(NSArray * _Nullable)tags;
        [Static]
        [Export("getBranchActivityItemWithParams:feature:stage:tags:")]
        //[Verify(StronglyTypedNSArray)]
        BranchActivityItemProvider GetBranchActivityItemWithParams(NSDictionary @params, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] NSObject[] tags);

        // +(BranchActivityItemProvider * _Nonnull)getBranchActivityItemWithParams:(NSDictionary * _Nonnull)params feature:(NSString * _Nullable)feature stage:(NSString * _Nullable)stage tags:(NSArray * _Nullable)tags alias:(NSString * _Nullable)alias;
        [Static]
        [Export("getBranchActivityItemWithParams:feature:stage:tags:alias:")]
        //[Verify(StronglyTypedNSArray)]
        BranchActivityItemProvider GetBranchActivityItemWithParams(NSDictionary @params, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] NSObject[] tags, [NullAllowed] string alias);

        // +(BranchActivityItemProvider * _Nonnull)getBranchActivityItemWithParams:(NSDictionary * _Nonnull)params feature:(NSString * _Nullable)feature stage:(NSString * _Nullable)stage campaign:(NSString * _Nullable)campaign tags:(NSArray * _Nullable)tags alias:(NSString * _Nullable)alias;
        [Static]
        [Export("getBranchActivityItemWithParams:feature:stage:campaign:tags:alias:")]
        //[Verify(StronglyTypedNSArray)]
        BranchActivityItemProvider GetBranchActivityItemWithParams(NSDictionary @params, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string campaign, [NullAllowed] NSObject[] tags, [NullAllowed] string alias);

        // +(BranchActivityItemProvider * _Nonnull)getBranchActivityItemWithParams:(NSDictionary * _Nonnull)params feature:(NSString * _Nullable)feature stage:(NSString * _Nullable)stage tags:(NSArray * _Nullable)tags alias:(NSString * _Nullable)alias delegate:(id<BranchActivityItemProviderDelegate> _Nullable)delegate;
        [Static]
        [Export("getBranchActivityItemWithParams:feature:stage:tags:alias:delegate:")]
        //[Verify(StronglyTypedNSArray)]
        BranchActivityItemProvider GetBranchActivityItemWithParams(NSDictionary @params, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] NSObject[] tags, [NullAllowed] string alias, [NullAllowed] BranchActivityItemProviderDelegate @delegate);

        // -(void)initSessionWithLaunchOptions:(NSDictionary * _Nullable)options;
        [Export("initSessionWithLaunchOptions:")]
        void InitSessionWithLaunchOptions([NullAllowed] NSDictionary options);

        // -(void)initSessionWithLaunchOptions:(NSDictionary * _Nullable)options isReferrable:(BOOL)isReferrable;
        [Export("initSessionWithLaunchOptions:isReferrable:")]
        void InitSessionWithLaunchOptions([NullAllowed] NSDictionary options, bool isReferrable);

        // -(void)initSessionWithLaunchOptions:(NSDictionary * _Nullable)options andRegisterDeepLinkHandler:(callbackWithParams _Nullable)callback;
        [Export("initSessionWithLaunchOptions:andRegisterDeepLinkHandler:")]
        void InitSessionWithLaunchOptions([NullAllowed] NSDictionary options, [NullAllowed] callbackWithParams callback);

        // -(void)initSessionWithLaunchOptions:(NSDictionary * _Nullable)options andRegisterDeepLinkHandlerUsingBranchUniversalObject:(callbackWithBranchUniversalObject _Nullable)callback;
        [Export("initSessionWithLaunchOptions:andRegisterDeepLinkHandlerUsingBranchUniversalObject:")]
        void InitSessionWithLaunchOptions([NullAllowed] NSDictionary options, [NullAllowed] callbackWithBranchUniversalObject callback);

        //// -(void)initSessionWithLaunchOptions:(NSDictionary * _Nullable)options automaticallyDisplayDeepLinkController:(BOOL)automaticallyDisplayController;
        //[Export("initSessionWithLaunchOptions:automaticallyDisplayDeepLinkController:")]
        //void InitSessionWithLaunchOptions([NullAllowed] NSDictionary options, bool automaticallyDisplayController);

        // -(void)initSessionWithLaunchOptions:(NSDictionary * _Nullable)options isReferrable:(BOOL)isReferrable andRegisterDeepLinkHandler:(callbackWithParams _Nullable)callback;
        [Export("initSessionWithLaunchOptions:isReferrable:andRegisterDeepLinkHandler:")]
        void InitSessionWithLaunchOptions([NullAllowed] NSDictionary options, bool isReferrable, [NullAllowed] callbackWithParams callback);

        //// -(void)initSessionWithLaunchOptions:(NSDictionary * _Nullable)options isReferrable:(BOOL)isReferrable automaticallyDisplayDeepLinkController:(BOOL)automaticallyDisplayController;
        //[Export("initSessionWithLaunchOptions:isReferrable:automaticallyDisplayDeepLinkController:")]
        //void InitSessionWithLaunchOptions([NullAllowed] NSDictionary options, bool isReferrable, bool automaticallyDisplayController);

        //// -(void)initSessionWithLaunchOptions:(NSDictionary * _Nullable)options automaticallyDisplayDeepLinkController:(BOOL)automaticallyDisplayController deepLinkHandler:(callbackWithParams _Nullable)callback;
        //[Export("initSessionWithLaunchOptions:automaticallyDisplayDeepLinkController:deepLinkHandler:")]
        //void InitSessionWithLaunchOptions([NullAllowed] NSDictionary options, bool automaticallyDisplayController, [NullAllowed] callbackWithParams callback);

        // -(void)initSessionWithLaunchOptions:(NSDictionary * _Nullable)options automaticallyDisplayDeepLinkController:(BOOL)automaticallyDisplayController isReferrable:(BOOL)isReferrable deepLinkHandler:(callbackWithParams _Nullable)callback;
        [Export("initSessionWithLaunchOptions:automaticallyDisplayDeepLinkController:isReferrable:deepLinkHandler:")]
        void InitSessionWithLaunchOptions([NullAllowed] NSDictionary options, bool automaticallyDisplayController, bool isReferrable, [NullAllowed] callbackWithParams callback);

        // -(BOOL)handleDeepLink:(NSURL * _Nullable)url;
        [Export("handleDeepLink:")]
        bool HandleDeepLink([NullAllowed] NSUrl url);

        // -(BOOL)handleDeepLinkWithNewSession:(NSURL * _Nullable)url;
        [Export("handleDeepLinkWithNewSession:")]
        bool HandleDeepLinkWithNewSession([NullAllowed] NSUrl url);

        // -(BOOL)continueUserActivity:(NSUserActivity * _Nullable)userActivity;
        [Export("continueUserActivity:")]
        bool ContinueUserActivity([NullAllowed] NSUserActivity userActivity);

        // -(BOOL)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)url sourceApplication:(NSString * _Nullable)sourceApplication annotation:(id _Nullable)annotation;
        [Export("application:openURL:sourceApplication:annotation:")]
        bool Application([NullAllowed] UIApplication application, [NullAllowed] NSUrl url, [NullAllowed] string sourceApplication, [NullAllowed] NSObject annotation);

        // -(BOOL)application:(UIApplication * _Nullable)application openURL:(NSURL * _Nullable)url options:(NSDictionary<UIApplicationOpenURLOptionsKey,id> * _Nullable)options;
        [Export("application:openURL:options:")]
        bool Application([NullAllowed] UIApplication application, [NullAllowed] NSUrl url, [NullAllowed] NSDictionary<NSString, NSObject> options);

        //// -(void)dispatchToIsolationQueue:(dispatch_block_t _Nonnull)initBlock;
        //[Export("dispatchToIsolationQueue:")]
        //void DispatchToIsolationQueue(dispatch_block_t initBlock);

        // -(void)handlePushNotification:(NSDictionary * _Nullable)userInfo;
        [Export("handlePushNotification:")]
        void HandlePushNotification([NullAllowed] NSDictionary userInfo);

        //// -(void)registerDeepLinkController:(UIViewController<BranchDeepLinkingController> * _Nullable)controller forKey:(NSString * _Nullable)key __attribute__((deprecated("This API is deprecated. Please use registerDeepLinkController: forKey: withOption:")));
        //[Export("registerDeepLinkController:forKey:")]
        //void RegisterDeepLinkController([NullAllowed] BranchDeepLinkingController controller, [NullAllowed] string key);

        //// -(void)registerDeepLinkController:(UIViewController<BranchDeepLinkingController> * _Nullable)controller forKey:(NSString * _Nullable)key withPresentation:(BNCViewControllerPresentationOption)option;
        //[Export("registerDeepLinkController:forKey:withPresentation:")]
        //void RegisterDeepLinkController([NullAllowed] BranchDeepLinkingController controller, [NullAllowed] string key, BNCViewControllerPresentationOption option);

        // -(void)setDebug;
        [Export("setDebug")]
        void SetDebug();

        // -(void)validateSDKIntegration;
        [Export("validateSDKIntegration")]
        void ValidateSDKIntegration();

        // -(void)setDeepLinkDebugMode:(NSDictionary * _Nullable)debugParams;
        [Export("setDeepLinkDebugMode:")]
        void SetDeepLinkDebugMode([NullAllowed] NSDictionary debugParams);

        // TODO: rename C# versions
        // -(void)addWhiteListedScheme:(NSString * _Nullable)scheme;
        [Export("addAllowedScheme:")]
        void AddWhiteListedScheme([NullAllowed] string scheme);

        // TODO: rename C# versions
        // -(void)setWhiteListedSchemes:(NSArray * _Nullable)schemes;
        [Export("setAllowedSchemes:")]
        //[Verify(StronglyTypedNSArray)]
        void SetWhiteListedSchemes([NullAllowed] NSObject[] schemes);

        // TODO: rename C# versions
        // @property (copy) NSArray<NSString *> * _Nullable blackListURLRegex;
        [NullAllowed, Export("urlPatternsToIgnore", ArgumentSemantic.Copy)]
        string[] BlackListURLRegex { get; set; }

        // -(void)registerFacebookDeepLinkingClass:(id _Nonnull)FBSDKAppLinkUtility;
        [Export("registerFacebookDeepLinkingClass:")]
        void RegisterFacebookDeepLinkingClass(NSObject FBSDKAppLinkUtility);

        // -(void)delayInitToCheckForSearchAds;
        [Export("delayInitToCheckForSearchAds")]
        void DelayInitToCheckForSearchAds();

        // -(void)useLongerWaitForAppleSearchAds;
        [Export("useLongerWaitForAppleSearchAds")]
        void UseLongerWaitForAppleSearchAds();

        // -(void)ignoreAppleSearchAdsTestData;
        [Export("ignoreAppleSearchAdsTestData")]
        void IgnoreAppleSearchAdsTestData();

        // - (void)enableLogging;
        [Export("enableLogging")]
        void EnableLogging();

        // - (void)checkPasteboardOnInstall;
        [Export("checkPasteboardOnInstall")]
        void CheckPasteboardOnInstall();

        // -(void)setRetryInterval:(NSTimeInterval)retryInterval;
        [Export("setRetryInterval:")]
        void SetRetryInterval(double retryInterval);

        // -(void)setMaxRetries:(NSInteger)maxRetries;
        [Export("setMaxRetries:")]
        void SetMaxRetries(nint maxRetries);

        // -(void)setNetworkTimeout:(NSTimeInterval)timeout;
        [Export("setNetworkTimeout:")]
        void SetNetworkTimeout(double timeout);

        // -(void)disableCookieBasedMatching __attribute__((deprecated("Feature removed.  Did not work on iOS 11+")));
        [Export("disableCookieBasedMatching")]
        void DisableCookieBasedMatching();

        // -(void)accountForFacebookSDKPreventingAppLaunch __attribute__((deprecated("Please ensure application:didFinishLaunchingWithOptions: always returns YES/true instead of using this method. It will be removed in a future release.")));
        [Export("accountForFacebookSDKPreventingAppLaunch")]
        void AccountForFacebookSDKPreventingAppLaunch();

        // -(void)suppressWarningLogs;
        [Export("suppressWarningLogs")]
        void SuppressWarningLogs();

        // -(void)registerPluginName:(NSString * _Nonnull)name version:(NSString * _Nonnull)version;
        [Export("registerPluginName:version:")]
        void RegisterPluginName(string name, string version);

        // -(void)setRequestMetadataKey:(NSString * _Nonnull)key value:(id _Nullable)value;
        [Export("setRequestMetadataKey:value:")]
        void SetRequestMetadataKey(string key, [NullAllowed] string value);

        // -(void)enableDelayedInit __attribute__((deprecated("No longer valid with new init process")));
        [Export("enableDelayedInit")]
        void EnableDelayedInit();

        // -(void)disableDelayedInit __attribute__((deprecated("No longer valid with new init process")));
        [Export("disableDelayedInit")]
        void DisableDelayedInit();

        // -(NSURL * _Nullable)getUrlForOnboardingWithRedirectUrl:(NSString * _Nullable)redirectUrl __attribute__((deprecated("Feature removed.  Did not work on iOS 11+")));
        [Export("getUrlForOnboardingWithRedirectUrl:")]
        [return: NullAllowed]
        NSUrl GetUrlForOnboardingWithRedirectUrl([NullAllowed] string redirectUrl);

        // -(void)resumeInit __attribute__((deprecated("Feature removed.  Did not work on iOS 11+")));
        [Export("resumeInit")]
        void ResumeInit();

        // -(void)setInstallRequestDelay:(NSInteger)installRequestDelay __attribute__((deprecated("No longer valid with new init process")));
        [Export("setInstallRequestDelay:")]
        void SetInstallRequestDelay(nint installRequestDelay);

        // +(BOOL)trackingDisabled;
        // +(void)setTrackingDisabled:(BOOL)disabled;
        [Static]
        [Export("trackingDisabled")]
        //[Verify(MethodToProperty)]
        bool TrackingDisabled { get; set; }

        // -(BranchUniversalObject * _Nullable)getFirstReferringBranchUniversalObject;
        [Export("getFirstReferringBranchUniversalObject")]
        //[Verify(MethodToProperty)]
        //BranchUniversalObject FirstReferringBranchUniversalObject { get; }
        BranchUniversalObject FirstReferringBranchUniversalObject();

        // -(BranchLinkProperties * _Nullable)getFirstReferringBranchLinkProperties;
        [Export("getFirstReferringBranchLinkProperties")]
        //[Verify(MethodToProperty)]
        //BranchLinkProperties FirstReferringBranchLinkProperties { get; }
        BranchLinkProperties FirstReferringBranchLinkProperties();

        // -(NSDictionary * _Nullable)getFirstReferringParams;
        [Export("getFirstReferringParams")]
        //[Verify(MethodToProperty)]
        //NSDictionary FirstReferringParams { get; }
        NSDictionary FirstReferringParams();

        // -(BranchUniversalObject * _Nullable)getLatestReferringBranchUniversalObject;
        [Export("getLatestReferringBranchUniversalObject")]
        //[Verify(MethodToProperty)]
        //BranchUniversalObject LatestReferringBranchUniversalObject { get; }
        BranchUniversalObject LatestReferringBranchUniversalObject();

        // -(BranchLinkProperties * _Nullable)getLatestReferringBranchLinkProperties;
        [Export("getLatestReferringBranchLinkProperties")]
        //[Verify(MethodToProperty)]
        //BranchLinkProperties LatestReferringBranchLinkProperties { get; }
        BranchLinkProperties LatestReferringBranchLinkProperties();

        // -(NSDictionary * _Nullable)getLatestReferringParams;
        [Export("getLatestReferringParams")]
        //[Verify(MethodToProperty)]
        //NSDictionary LatestReferringParams { get; }
        NSDictionary LatestReferringParams();

        // -(NSDictionary * _Nullable)getLatestReferringParamsSynchronous;
        [Export("getLatestReferringParamsSynchronous")]
        //[Verify(MethodToProperty)]
        //NSDictionary LatestReferringParamsSynchronous { get; }
        NSDictionary LatestReferringParamsSynchronous();

        // -(void)resetUserSession;
        [Export("resetUserSession")]
        void ResetUserSession();

        // -(BOOL)isUserIdentified;
        [Export("isUserIdentified")]
        //[Verify(MethodToProperty)]
        bool IsUserIdentified { get; }

        // -(void)setIdentity:(NSString * _Nullable)userId;
        [Export("setIdentity:")]
        void SetIdentity([NullAllowed] string userId);

        // -(void)setIdentity:(NSString * _Nullable)userId withCallback:(callbackWithParams _Nullable)callback;
        [Export("setIdentity:withCallback:")]
        void SetIdentity([NullAllowed] string userId, [NullAllowed] callbackWithParams callback);

        // -(void)logout;
        [Export("logout")]
        void Logout();

        // -(void)logoutWithCallback:(callbackWithStatus _Nullable)callback;
        [Export("logoutWithCallback:")]
        void LogoutWithCallback([NullAllowed] callbackWithStatus callback);

        // -(void)userCompletedAction:(NSString * _Nullable)action;
        [Export("userCompletedAction:")]
        void UserCompletedAction([NullAllowed] string action);

        // -(void)userCompletedAction:(NSString * _Nullable)action withState:(NSDictionary * _Nullable)state;
        [Export("userCompletedAction:withState:")]
        void UserCompletedAction([NullAllowed] string action, [NullAllowed] NSDictionary state);

        // -(void)userCompletedAction:(NSString * _Nullable)action withState:(NSDictionary * _Nullable)state withDelegate:(id _Nullable)branchViewCallback __attribute__((deprecated("This API is deprecated. Please use userCompletedAction:action:state instead.")));
        [Export("userCompletedAction:withState:withDelegate:")]
        void UserCompletedAction([NullAllowed] string action, [NullAllowed] NSDictionary state, [NullAllowed] NSObject branchViewCallback);

        // -(void)sendCommerceEvent:(BNCCommerceEvent * _Nonnull)commerceEvent metadata:(NSDictionary<NSString *,id> * _Nonnull)metadata withCompletion:(void (^ _Nonnull)(NSDictionary * _Nullable, NSError * _Nullable))completion __attribute__((deprecated("Please use BranchEvent to track commerce events.")));
        [Export("sendCommerceEvent:metadata:withCompletion:")]
        void SendCommerceEvent(BNCCommerceEvent commerceEvent, NSDictionary<NSString, NSObject> metadata, Action<NSDictionary, NSError> completion);

        // -(void)crossPlatformIdDataWithCompletion:(void (^ _Nonnull)(BranchCrossPlatformID * _Nullable))completion;
        [Export("crossPlatformIdDataWithCompletion:")]
        void CrossPlatformIdDataWithCompletion(Action<BranchCrossPlatformID> completion);

        // -(void)lastAttributedTouchDataWithAttributionWindow:(NSInteger)window completion:(void (^ _Nonnull)(BranchLastAttributedTouchData * _Nullable))completion;
        [Export("lastAttributedTouchDataWithAttributionWindow:completion:")]
        void LastAttributedTouchDataWithAttributionWindow(nint window, Action<BranchLastAttributedTouchData> completion);

        // -(NSString * _Nonnull)getShortURL;
        [Export("getShortURL")]
        //[Verify(MethodToProperty)]
        string ShortURL { get; }

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params;
        [Export("getShortURLWithParams:")]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature;
        [Export("getShortURLWithParams:andChannel:andFeature:")]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage;
        [Export("getShortURLWithParams:andChannel:andFeature:andStage:")]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andAlias:(NSString * _Nullable)alias;
        [Export("getShortURLWithParams:andChannel:andFeature:andStage:andAlias:")]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string alias);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andType:(BranchLinkType)type;
        [Export("getShortURLWithParams:andChannel:andFeature:andStage:andType:")]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, BranchLinkType type);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andMatchDuration:(NSUInteger)duration;
        [Export("getShortURLWithParams:andChannel:andFeature:andStage:andMatchDuration:")]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, nuint duration);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:")]
        //[Verify(StronglyTypedNSArray)]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andAlias:(NSString * _Nullable)alias;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andAlias:")]
        //[Verify(StronglyTypedNSArray)]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string alias);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andAlias:(NSString * _Nullable)alias ignoreUAString:(NSString * _Nullable)ignoreUAString;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andAlias:ignoreUAString:")]
        //[Verify(StronglyTypedNSArray)]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string alias, [NullAllowed] string ignoreUAString);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andCampaign:(NSString * _Nullable)campaign andAlias:(NSString * _Nullable)alias ignoreUAString:(NSString * _Nullable)ignoreUAString forceLinkCreation:(BOOL)forceLinkCreation;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andCampaign:andAlias:ignoreUAString:forceLinkCreation:")]
        //[Verify(StronglyTypedNSArray)]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string campaign, [NullAllowed] string alias, [NullAllowed] string ignoreUAString, bool forceLinkCreation);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andType:(BranchLinkType)type;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andType:")]
        //[Verify(StronglyTypedNSArray)]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, BranchLinkType type);

        // -(NSString * _Nonnull)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andMatchDuration:(NSUInteger)duration;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andMatchDuration:")]
        //[Verify(StronglyTypedNSArray)]
        string GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, nuint duration);

        // -(NSString * _Nonnull)getShortUrlWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andAlias:(NSString * _Nullable)alias andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andMatchDuration:(NSUInteger)duration;
        [Export("getShortUrlWithParams:andTags:andAlias:andChannel:andFeature:andStage:andMatchDuration:")]
        //[Verify(StronglyTypedNSArray)]
        string GetShortUrlWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string alias, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, nuint duration);

        // -(NSString * _Nonnull)getShortUrlWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andAlias:(NSString * _Nullable)alias andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andCampaign:(id)campaign andMatchDuration:(NSUInteger)duration;
        [Export("getShortUrlWithParams:andTags:andAlias:andChannel:andFeature:andStage:andCampaign:andMatchDuration:")]
        //[Verify(StronglyTypedNSArray)]
        string GetShortUrlWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string alias, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, NSObject campaign, nuint duration);

        // -(NSString * _Nonnull)getLongURLWithParams:(NSDictionary * _Nullable)params;
        [Export("getLongURLWithParams:")]
        string GetLongURLWithParams([NullAllowed] NSDictionary @params);

        // -(NSString * _Nonnull)getLongURLWithParams:(NSDictionary * _Nullable)params andFeature:(NSString * _Nullable)feature;
        [Export("getLongURLWithParams:andFeature:")]
        string GetLongURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string feature);

        // -(NSString * _Nonnull)getLongURLWithParams:(NSDictionary * _Nullable)params andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage;
        [Export("getLongURLWithParams:andFeature:andStage:")]
        string GetLongURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string feature, [NullAllowed] string stage);

        // -(NSString * _Nonnull)getLongURLWithParams:(NSDictionary * _Nullable)params andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andTags:(NSArray * _Nullable)tags;
        [Export("getLongURLWithParams:andFeature:andStage:andTags:")]
        //[Verify(StronglyTypedNSArray)]
        string GetLongURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] NSObject[] tags);

        // -(NSString * _Nonnull)getLongURLWithParams:(NSDictionary * _Nullable)params andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andAlias:(NSString * _Nullable)alias;
        [Export("getLongURLWithParams:andFeature:andStage:andAlias:")]
        string GetLongURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string alias);

        // -(NSString * _Nonnull)getLongURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andTags:(NSArray * _Nullable)tags andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andAlias:(NSString * _Nullable)alias;
        [Export("getLongURLWithParams:andChannel:andTags:andFeature:andStage:andAlias:")]
        //[Verify(StronglyTypedNSArray)]
        string GetLongURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] NSObject[] tags, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string alias);

        // -(void)getShortURLWithCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithCallback:")]
        void GetShortURLWithCallback([NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andCallback:")]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andChannel:andFeature:andCallback:")]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andChannel:andFeature:andStage:andCallback:")]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andAlias:(NSString * _Nullable)alias andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andChannel:andFeature:andStage:andAlias:andCallback:")]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string alias, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andType:(BranchLinkType)type andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andChannel:andFeature:andStage:andType:andCallback:")]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, BranchLinkType type, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andMatchDuration:(NSUInteger)duration andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andChannel:andFeature:andStage:andMatchDuration:andCallback:")]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, nuint duration, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andCallback:")]
        //[Verify(StronglyTypedNSArray)]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andAlias:(NSString * _Nullable)alias andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andAlias:andCallback:")]
        //[Verify(StronglyTypedNSArray)]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string alias, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andType:(BranchLinkType)type andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andType:andCallback:")]
        //[Verify(StronglyTypedNSArray)]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, BranchLinkType type, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortURLWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andMatchDuration:(NSUInteger)duration andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortURLWithParams:andTags:andChannel:andFeature:andStage:andMatchDuration:andCallback:")]
        //[Verify(StronglyTypedNSArray)]
        void GetShortURLWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, nuint duration, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortUrlWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andAlias:(NSString * _Nullable)alias andMatchDuration:(NSUInteger)duration andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortUrlWithParams:andTags:andAlias:andMatchDuration:andChannel:andFeature:andStage:andCallback:")]
        //[Verify(StronglyTypedNSArray)]
        void GetShortUrlWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string alias, nuint duration, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] callbackWithUrl callback);

        // -(void)getShortUrlWithParams:(NSDictionary * _Nullable)params andTags:(NSArray * _Nullable)tags andAlias:(NSString * _Nullable)alias andMatchDuration:(NSUInteger)duration andChannel:(NSString * _Nullable)channel andFeature:(NSString * _Nullable)feature andStage:(NSString * _Nullable)stage andCampaign:(NSString * _Nullable)campaign andCallback:(callbackWithUrl _Nullable)callback;
        [Export("getShortUrlWithParams:andTags:andAlias:andMatchDuration:andChannel:andFeature:andStage:andCampaign:andCallback:")]
        //[Verify(StronglyTypedNSArray)]
        void GetShortUrlWithParams([NullAllowed] NSDictionary @params, [NullAllowed] NSObject[] tags, [NullAllowed] string alias, nuint duration, [NullAllowed] string channel, [NullAllowed] string feature, [NullAllowed] string stage, [NullAllowed] string campaign, [NullAllowed] callbackWithUrl callback);

        // -(void)getSpotlightUrlWithParams:(NSDictionary * _Nonnull)params callback:(callbackWithParams _Nonnull)callback;
        [Export("getSpotlightUrlWithParams:callback:")]
        void GetSpotlightUrlWithParams(NSDictionary @params, callbackWithParams callback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description;
        [Export("createDiscoverableContentWithTitle:description:")]
        void CreateDiscoverableContentWithTitle(string title, string description);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description callback:(callbackWithUrl _Nonnull)callback;
        [Export("createDiscoverableContentWithTitle:description:callback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, callbackWithUrl callback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description publiclyIndexable:(BOOL)publiclyIndexable callback:(callbackWithUrl _Nonnull)callback;
        [Export("createDiscoverableContentWithTitle:description:publiclyIndexable:callback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, bool publiclyIndexable, callbackWithUrl callback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable callback:(callbackWithUrl _Nonnull)callback;
        [Export("createDiscoverableContentWithTitle:description:type:publiclyIndexable:callback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, string type, bool publiclyIndexable, callbackWithUrl callback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable callback:(callbackWithUrl _Nonnull)callback;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:type:publiclyIndexable:callback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, string type, bool publiclyIndexable, callbackWithUrl callback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable keywords:(NSSet * _Nonnull)keywords callback:(callbackWithUrl _Nonnull)callback;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:type:publiclyIndexable:keywords:callback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, string type, bool publiclyIndexable, NSSet keywords, callbackWithUrl callback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl linkParams:(NSDictionary * _Nonnull)linkParams publiclyIndexable:(BOOL)publiclyIndexable keywords:(NSSet * _Nonnull)keywords;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:linkParams:publiclyIndexable:keywords:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, NSDictionary linkParams, bool publiclyIndexable, NSSet keywords);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl linkParams:(NSDictionary * _Nonnull)linkParams type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable keywords:(NSSet * _Nonnull)keywords;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:linkParams:type:publiclyIndexable:keywords:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, NSDictionary linkParams, string type, bool publiclyIndexable, NSSet keywords);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable keywords:(NSSet * _Nonnull)keywords;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:type:publiclyIndexable:keywords:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, string type, bool publiclyIndexable, NSSet keywords);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl linkParams:(NSDictionary * _Nonnull)linkParams publiclyIndexable:(BOOL)publiclyIndexable;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:linkParams:publiclyIndexable:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, NSDictionary linkParams, bool publiclyIndexable);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl linkParams:(NSDictionary * _Nonnull)linkParams type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable keywords:(NSSet * _Nonnull)keywords callback:(callbackWithUrl _Nonnull)callback;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:linkParams:type:publiclyIndexable:keywords:callback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, NSDictionary linkParams, string type, bool publiclyIndexable, NSSet keywords, callbackWithUrl callback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl linkParams:(NSDictionary * _Nonnull)linkParams type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable keywords:(NSSet * _Nonnull)keywords expirationDate:(NSDate * _Nonnull)expirationDate callback:(callbackWithUrl _Nonnull)callback;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:linkParams:type:publiclyIndexable:keywords:expirationDate:callback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, NSDictionary linkParams, string type, bool publiclyIndexable, NSSet keywords, NSDate expirationDate, callbackWithUrl callback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl canonicalId:(NSString * _Nonnull)canonicalId linkParams:(NSDictionary * _Nonnull)linkParams type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable keywords:(NSSet * _Nonnull)keywords expirationDate:(NSDate * _Nonnull)expirationDate callback:(callbackWithUrl _Nonnull)callback;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:canonicalId:linkParams:type:publiclyIndexable:keywords:expirationDate:callback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, string canonicalId, NSDictionary linkParams, string type, bool publiclyIndexable, NSSet keywords, NSDate expirationDate, callbackWithUrl callback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl linkParams:(NSDictionary * _Nonnull)linkParams type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable keywords:(NSSet * _Nonnull)keywords expirationDate:(NSDate * _Nonnull)expirationDate spotlightCallback:(callbackWithUrlAndSpotlightIdentifier _Nonnull)spotlightCallback;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:linkParams:type:publiclyIndexable:keywords:expirationDate:spotlightCallback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, NSDictionary linkParams, string type, bool publiclyIndexable, NSSet keywords, NSDate expirationDate, callbackWithUrlAndSpotlightIdentifier spotlightCallback);

        // -(void)createDiscoverableContentWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description thumbnailUrl:(NSURL * _Nonnull)thumbnailUrl canonicalId:(NSString * _Nonnull)canonicalId linkParams:(NSDictionary * _Nonnull)linkParams type:(NSString * _Nonnull)type publiclyIndexable:(BOOL)publiclyIndexable keywords:(NSSet * _Nonnull)keywords expirationDate:(NSDate * _Nonnull)expirationDate spotlightCallback:(callbackWithUrlAndSpotlightIdentifier _Nonnull)spotlightCallback;
        [Export("createDiscoverableContentWithTitle:description:thumbnailUrl:canonicalId:linkParams:type:publiclyIndexable:keywords:expirationDate:spotlightCallback:")]
        void CreateDiscoverableContentWithTitle(string title, string description, NSUrl thumbnailUrl, string canonicalId, NSDictionary linkParams, string type, bool publiclyIndexable, NSSet keywords, NSDate expirationDate, callbackWithUrlAndSpotlightIdentifier spotlightCallback);

        // -(void)indexOnSpotlightWithBranchUniversalObject:(BranchUniversalObject * _Nonnull)universalObject linkProperties:(BranchLinkProperties * _Nullable)linkProperties completion:(void (^ _Nonnull)(BranchUniversalObject * _Nonnull, NSString * _Nonnull, NSError * _Nonnull))completion;
        [Export("indexOnSpotlightWithBranchUniversalObject:linkProperties:completion:")]
        void IndexOnSpotlightWithBranchUniversalObject(BranchUniversalObject universalObject, [NullAllowed] BranchLinkProperties linkProperties, Action<BranchUniversalObject, NSString, NSError> completion);

        //// -(void)indexOnSpotlightUsingSearchableItems:(NSArray<BranchUniversalObject *> * _Nonnull)universalObjects completion:(void (^ _Nonnull)(NSArray<BranchUniversalObject *> * _Nonnull, NSError * _Nonnull))completion;
        //[Export("indexOnSpotlightUsingSearchableItems:completion:")]
        //void IndexOnSpotlightUsingSearchableItems(BranchUniversalObject[] universalObjects, Action<NSArray<BranchUniversalObject>, NSError> completion);

        // -(void)removeSearchableItemWithBranchUniversalObject:(BranchUniversalObject * _Nonnull)universalObject callback:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("removeSearchableItemWithBranchUniversalObject:callback:")]
        void RemoveSearchableItemWithBranchUniversalObject(BranchUniversalObject universalObject, [NullAllowed] Action<NSError> completion);

        // -(void)removeSearchableItemsWithBranchUniversalObjects:(NSArray<BranchUniversalObject *> * _Nonnull)universalObjects callback:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("removeSearchableItemsWithBranchUniversalObjects:callback:")]
        void RemoveSearchableItemsWithBranchUniversalObjects(BranchUniversalObject[] universalObjects, [NullAllowed] Action<NSError> completion);

        // -(void)removeAllPrivateContentFromSpotLightWithCallback:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("removeAllPrivateContentFromSpotLightWithCallback:")]
        void RemoveAllPrivateContentFromSpotLightWithCallback([NullAllowed] Action<NSError> completion);

        // -(id _Nonnull)initWithInterface:(BNCServerInterface * _Nonnull)interface queue:(BNCServerRequestQueue * _Nonnull)queue cache:(BNCLinkCache * _Nonnull)cache preferenceHelper:(BNCPreferenceHelper * _Nonnull)preferenceHelper key:(NSString * _Nonnull)key;
        [Export("initWithInterface:queue:cache:preferenceHelper:key:")]
        IntPtr Constructor(BNCServerInterface @interface, BNCServerRequestQueue queue, BNCLinkCache cache, BNCPreferenceHelper preferenceHelper, string key);

        // -(void)registerViewWithParams:(NSDictionary * _Nonnull)params andCallback:(callbackWithParams _Nonnull)callback __attribute__((deprecated("This API is deprecated. Please use BranchEvent:BranchStandardEventViewItem instead.")));
        [Export("registerViewWithParams:andCallback:")]
        void RegisterViewWithParams(NSDictionary @params, callbackWithParams callback);

        // -(void)sendServerRequest:(BNCServerRequest * _Nonnull)request;
        [Export("sendServerRequest:")]
        void SendServerRequest(BNCServerRequest request);

        // -(void)sendServerRequestWithoutSession:(BNCServerRequest * _Nonnull)request __attribute__((deprecated("This API is deprecated. Please use sendServerRequest instead.")));
        [Export("sendServerRequestWithoutSession:")]
        void SendServerRequestWithoutSession(BNCServerRequest request);

        // @property (copy, nonatomic) void (^ _Nonnull)(NSDictionary * _Nullable, NSError * _Nullable) sessionInitWithParamsCallback;
        [Export("sessionInitWithParamsCallback", ArgumentSemantic.Copy)]
        Action<NSDictionary, NSError> SessionInitWithParamsCallback { get; set; }

        // @property (copy, nonatomic) void (^ _Nonnull)(BranchUniversalObject * _Nullable, BranchLinkProperties * _Nullable, NSError * _Nullable) sessionInitWithBranchUniversalObjectCallback;
        [Export("sessionInitWithBranchUniversalObjectCallback", ArgumentSemantic.Copy)]
        Action<BranchUniversalObject, BranchLinkProperties, NSError> SessionInitWithBranchUniversalObjectCallback { get; set; }

        // @property (readonly, strong) BNCServerInterface * _Nonnull serverInterface;
        [Export("serverInterface", ArgumentSemantic.Strong)]
        BNCServerInterface ServerInterface { get; }

        // -(void)clearNetworkQueue;
        [Export("clearNetworkQueue")]
        void ClearNetworkQueue();
    }

}