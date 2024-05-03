; ModuleID = 'obj/Debug/android/marshal_methods.arm64-v8a.ll'
source_filename = "obj/Debug/android/marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [198 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 42
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 3
	i64 210515253464952879, ; 2: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 28
	i64 232391251801502327, ; 3: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 65
	i64 233177144301842968, ; 4: Xamarin.AndroidX.Collection.Jvm.dll => 0x33c696097d9f218 => 29
	i64 316157742385208084, ; 5: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 34
	i64 634308326490598313, ; 6: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 54
	i64 666284596546843206, ; 7: storyly.xamarin.binding.dll => 0x93f1e4f787d3246 => 5
	i64 687654259221141486, ; 8: Xamarin.GooglePlayServices.Base => 0x98b09e7c92917ee => 84
	i64 702024105029695270, ; 9: System.Drawing.Common => 0x9be17343c0e7726 => 96
	i64 872800313462103108, ; 10: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 41
	i64 1000557547492888992, ; 11: Mono.Security.dll => 0xde2b1c9cba651a0 => 97
	i64 1120440138749646132, ; 12: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 78
	i64 1315114680217950157, ; 13: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 24
	i64 1624659445732251991, ; 14: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 22
	i64 1628611045998245443, ; 15: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 56
	i64 1636321030536304333, ; 16: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 50
	i64 1665465927903229094, ; 17: Xamarin.AndroidX.Emoji => 0x171cec6ffa3034a6 => 44
	i64 1795316252682057001, ; 18: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 23
	i64 1836611346387731153, ; 19: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 65
	i64 1875917498431009007, ; 20: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 19
	i64 1981742497975770890, ; 21: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 55
	i64 2136356949452311481, ; 22: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 60
	i64 2165310824878145998, ; 23: Xamarin.Android.Glide.GifDecoder => 0x1e0cbab9112b81ce => 15
	i64 2165725771938924357, ; 24: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 26
	i64 2203565783020068373, ; 25: Xamarin.KotlinX.Coroutines.Core => 0x1e94a367981dde15 => 94
	i64 2262844636196693701, ; 26: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 41
	i64 2304837677853103545, ; 27: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0x1ffc6da80d5ed5b9 => 64
	i64 2329709569556905518, ; 28: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 52
	i64 2470498323731680442, ; 29: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 33
	i64 2479423007379663237, ; 30: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 69
	i64 2497223385847772520, ; 31: System.Runtime => 0x22a7eb7046413568 => 11
	i64 2547086958574651984, ; 32: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 18
	i64 2592350477072141967, ; 33: System.Xml.dll => 0x23f9e10627330e8f => 12
	i64 2624866290265602282, ; 34: mscorlib.dll => 0x246d65fbde2db8ea => 4
	i64 2787234703088983483, ; 35: Xamarin.AndroidX.Startup.StartupRuntime => 0x26ae3f31ef429dbb => 66
	i64 2923871038697555247, ; 36: Jsr305Binding => 0x2893ad37e69ec52f => 2
	i64 3017704767998173186, ; 37: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 78
	i64 3289520064315143713, ; 38: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 51
	i64 3303437397778967116, ; 39: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 20
	i64 3311221304742556517, ; 40: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 10
	i64 3344514922410554693, ; 41: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 95
	i64 3411255996856937470, ; 42: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 85
	i64 3493805808809882663, ; 43: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 67
	i64 3531994851595924923, ; 44: System.Numerics => 0x31042a9aade235bb => 9
	i64 3571415421602489686, ; 45: System.Runtime.dll => 0x319037675df7e556 => 11
	i64 3727469159507183293, ; 46: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 63
	i64 3772598417116884899, ; 47: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 42
	i64 4201423742386704971, ; 48: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 34
	i64 4247996603072512073, ; 49: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 87
	i64 4636684751163556186, ; 50: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 71
	i64 4759461199762736555, ; 51: Xamarin.AndroidX.Lifecycle.Process.dll => 0x420d00be961cc5ab => 53
	i64 4794310189461587505, ; 52: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 18
	i64 5039485380249333372, ; 53: Xamarin.JetBrains.KotlinXSerializationCoreJvm => 0x45efd940c4892e7c => 89
	i64 5054645606572944877, ; 54: Xamarin.Google.J2Objc.Annotations => 0x4625b5660544eded => 83
	i64 5203618020066742981, ; 55: Xamarin.Essentials => 0x4836f704f0e652c5 => 77
	i64 5205316157927637098, ; 56: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 58
	i64 5348796042099802469, ; 57: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 59
	i64 5376510917114486089, ; 58: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 69
	i64 5408338804355907810, ; 59: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 68
	i64 5451019430259338467, ; 60: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 32
	i64 5507995362134886206, ; 61: System.Core.dll => 0x4c705499688c873e => 6
	i64 5574231584441077149, ; 62: Xamarin.AndroidX.Annotation.Jvm => 0x4d5ba617ae5f8d9d => 21
	i64 5646229787742691871, ; 63: Xamarin.AndroidX.DataBinding.ViewBinding => 0x4e5b7013b2a1e21f => 39
	i64 5692067934154308417, ; 64: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 73
	i64 5724799082821825042, ; 65: Xamarin.AndroidX.ExifInterface => 0x4f72926f3e13b212 => 47
	i64 5757522595884336624, ; 66: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 30
	i64 5883779497439293579, ; 67: Xamarin.CheckerFramework.CheckerCompatQual => 0x51a762478198708b => 74
	i64 6319713645133255417, ; 68: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 54
	i64 6401687960814735282, ; 69: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 52
	i64 6410042373069515327, ; 70: com.storyly.xamarin => 0x58f50b939202aa3f => 0
	i64 6488212725793258232, ; 71: Xamarin.JetBrains.KotlinXSerializationCoreJvm.dll => 0x5a0ac3191c137af8 => 89
	i64 6504860066809920875, ; 72: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 26
	i64 6521302406919318474, ; 73: Xamarin.AndroidX.Emoji.AppCompat => 0x5a8051fcdd536bca => 43
	i64 6548213210057960872, ; 74: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 37
	i64 6589202984700901502, ; 75: Xamarin.Google.ErrorProne.Annotations.dll => 0x5b718d34180a787e => 79
	i64 6894844156784520562, ; 76: System.Numerics.Vectors => 0x5faf683aead1ad72 => 10
	i64 7103753931438454322, ; 77: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 49
	i64 7192745174564810625, ; 78: Xamarin.Android.Glide.GifDecoder.dll => 0x63d1c3a0a1d72f81 => 15
	i64 7250931609272990122, ; 79: Xamarin.Android.JetBrains.KotlinXSerializationJson.dll => 0x64a07be1ad5e39aa => 16
	i64 7349431895026339542, ; 80: Xamarin.Android.Glide.DiskLruCache => 0x65fe6d5e9bf88ed6 => 13
	i64 7637365915383206639, ; 81: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 77
	i64 7654504624184590948, ; 82: System.Net.Http => 0x6a3a4366801b8264 => 8
	i64 7686972674785783987, ; 83: com.storyly.xamarin.dll => 0x6aad9ceb9ebdb0b3 => 0
	i64 7735352534559001595, ; 84: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 92
	i64 7836164640616011524, ; 85: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 22
	i64 8044118961405839122, ; 86: System.ComponentModel.Composition => 0x6fa2739369944712 => 98
	i64 8083354569033831015, ; 87: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 51
	i64 8167236081217502503, ; 88: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 1
	i64 8187640529827139739, ; 89: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 93
	i64 8398329775253868912, ; 90: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 31
	i64 8426919725312979251, ; 91: Xamarin.AndroidX.Lifecycle.Process => 0x74f26ed7aa033133 => 53
	i64 8598790081731763592, ; 92: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x77550a055fc61d88 => 46
	i64 8601935802264776013, ; 93: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 68
	i64 8613760304861496997, ; 94: Xamarin.CodeHaus.Mojo.AnimalSnifferAnnotations.dll => 0x778a395c0fa146a5 => 76
	i64 8626175481042262068, ; 95: Java.Interop => 0x77b654e585b55834 => 1
	i64 8853378295825400934, ; 96: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 91
	i64 8951477988056063522, ; 97: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0x7c3a09cd9ccf5e22 => 62
	i64 9031035476476434958, ; 98: Xamarin.KotlinX.Coroutines.Core.dll => 0x7d54aeead9541a0e => 94
	i64 9312692141327339315, ; 99: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 73
	i64 9324707631942237306, ; 100: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 23
	i64 9436608531050192802, ; 101: Xamarin.JetBrains.KotlinXSerializationJsonJvm.dll => 0x82f5917631aadfa2 => 90
	i64 9662334977499516867, ; 102: System.Numerics.dll => 0x8617827802b0cfc3 => 9
	i64 9678050649315576968, ; 103: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 33
	i64 9700793525613939510, ; 104: Xamarin.Chromium.CroNet.Api => 0x86a0245085a0cb36 => 75
	i64 9711637524876806384, ; 105: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 59
	i64 9808709177481450983, ; 106: Mono.Android.dll => 0x881f890734e555e7 => 3
	i64 9825649861376906464, ; 107: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 30
	i64 9875200773399460291, ; 108: Xamarin.GooglePlayServices.Base.dll => 0x890bc2c8482339c3 => 84
	i64 9907349773706910547, ; 109: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x897dfa20b758db53 => 46
	i64 9920911484407516313, ; 110: Xamarin.AndroidX.Emoji.AppCompat.dll => 0x89ae286e8c340c99 => 43
	i64 9998632235833408227, ; 111: Mono.Security => 0x8ac2470b209ebae3 => 97
	i64 10038780035334861115, ; 112: System.Net.Http.dll => 0x8b50e941206af13b => 8
	i64 10071983904436292605, ; 113: Xamarin.CodeHaus.Mojo.AnimalSnifferAnnotations => 0x8bc6dfff57608bfd => 76
	i64 10229024438826829339, ; 114: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 37
	i64 10321854143672141184, ; 115: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 88
	i64 10376576884623852283, ; 116: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 67
	i64 10406448008575299332, ; 117: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 95
	i64 10430153318873392755, ; 118: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 35
	i64 10847732767863316357, ; 119: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 24
	i64 11019817191295005410, ; 120: Xamarin.AndroidX.Annotation.Jvm.dll => 0x98ee415998e1b2e2 => 21
	i64 11023048688141570732, ; 121: System.Core => 0x98f9bc61168392ac => 6
	i64 11037814507248023548, ; 122: System.Xml => 0x992e31d0412bf7fc => 12
	i64 11071824625609515081, ; 123: Xamarin.Google.ErrorProne.Annotations => 0x99a705d600e0a049 => 79
	i64 11136029745144976707, ; 124: Jsr305Binding.dll => 0x9a8b200d4f8cd543 => 2
	i64 11162124722117608902, ; 125: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 72
	i64 11299661109949763898, ; 126: Xamarin.AndroidX.Collection.Jvm => 0x9cd075e94cda113a => 29
	i64 11311541482613079101, ; 127: Xamarin.Android.Volley.dll => 0x9cfaab0c1d3f7c3d => 17
	i64 11340910727871153756, ; 128: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 36
	i64 11392833485892708388, ; 129: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 61
	i64 11529969570048099689, ; 130: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 72
	i64 11557885951453340159, ; 131: Xamarin.CheckerFramework.CheckerCompatQual.dll => 0xa065dc095adaa1ff => 74
	i64 11580057168383206117, ; 132: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 19
	i64 11591352189662810718, ; 133: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0xa0dcc167234c525e => 66
	i64 11647279585709470180, ; 134: Xamarin.Google.J2Objc.Annotations.dll => 0xa1a37312c1df31e4 => 83
	i64 11672361001936329215, ; 135: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 49
	i64 12137774235383566651, ; 136: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 70
	i64 12191646537372739477, ; 137: Xamarin.Android.Glide.dll => 0xa9316dee7f392795 => 14
	i64 12451044538927396471, ; 138: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 48
	i64 12466513435562512481, ; 139: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 57
	i64 12487638416075308985, ; 140: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 40
	i64 12538491095302438457, ; 141: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 27
	i64 12700543734426720211, ; 142: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 28
	i64 12963446364377008305, ; 143: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 96
	i64 12982280885948128408, ; 144: Xamarin.AndroidX.CustomView.PoolingContainer => 0xb42a53aec5481c98 => 38
	i64 13035583322324507960, ; 145: Xamarin.Android.Volley => 0xb4e7b1f757289d38 => 17
	i64 13129914918964716986, ; 146: Xamarin.AndroidX.Emoji2.dll => 0xb636d40db3fe65ba => 45
	i64 13401370062847626945, ; 147: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 70
	i64 13402939433517888790, ; 148: Xamarin.Google.Guava.FailureAccess => 0xba00ce6728e8b516 => 81
	i64 13404347523447273790, ; 149: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 31
	i64 13454009404024712428, ; 150: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 82
	i64 13465488254036897740, ; 151: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 92
	i64 13491513212026656886, ; 152: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 25
	i64 13572454107664307259, ; 153: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 63
	i64 13621154251410165619, ; 154: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0xbd080f9faa1acf73 => 38
	i64 13828521679616088467, ; 155: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 91
	i64 13865727802090930648, ; 156: Xamarin.Google.Guava.dll => 0xc06cf5f8e3e341d8 => 80
	i64 13959074834287824816, ; 157: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 48
	i64 13975254687929967048, ; 158: Xamarin.Google.Guava => 0xc1f2141837ada1c8 => 80
	i64 14124974489674258913, ; 159: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 27
	i64 14172845254133543601, ; 160: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 60
	i64 14261073672896646636, ; 161: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 61
	i64 14331727281556788554, ; 162: Xamarin.Android.Glide.DiskLruCache.dll => 0xc6e48607a2f7954a => 13
	i64 14495724990987328804, ; 163: Xamarin.AndroidX.ResourceInspection.Annotation => 0xc92b2913e18d5d24 => 64
	i64 14644440854989303794, ; 164: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 58
	i64 14792063746108907174, ; 165: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 82
	i64 14852515768018889994, ; 166: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 36
	i64 14988210264188246988, ; 167: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 40
	i64 15150743910298169673, ; 168: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xd2424150783c3149 => 62
	i64 15279429628684179188, ; 169: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 93
	i64 15370334346939861994, ; 170: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 35
	i64 15582737692548360875, ; 171: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 56
	i64 15609085926864131306, ; 172: System.dll => 0xd89e9cf3334914ea => 7
	i64 15678662497705792039, ; 173: Xamarin.JetBrains.KotlinXSerializationJsonJvm => 0xd995cc78f8fe1227 => 90
	i64 15859430286593069704, ; 174: Xamarin.AndroidX.Emoji.dll => 0xdc1803d19c739288 => 44
	i64 15930129725311349754, ; 175: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 87
	i64 16154507427712707110, ; 176: System => 0xe03056ea4e39aa26 => 7
	i64 16349252411473956627, ; 177: Xamarin.Chromium.CroNet.Api.dll => 0xe2e43672391a8f13 => 75
	i64 16361933716545543812, ; 178: Xamarin.AndroidX.ExifInterface.dll => 0xe3114406a52f1e84 => 47
	i64 16453318007624239004, ; 179: Xamarin.AndroidX.DataBinding.ViewBinding.dll => 0xe455ed8df4fb079c => 39
	i64 16565028646146589191, ; 180: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 98
	i64 16579050217386591297, ; 181: Xamarin.Google.Guava.FailureAccess.dll => 0xe6149e5548b0c441 => 81
	i64 16621146507174665210, ; 182: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 32
	i64 16833383113903931215, ; 183: mscorlib => 0xe99c30c1484d7f4f => 4
	i64 17024911836938395553, ; 184: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 20
	i64 17037200463775726619, ; 185: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 50
	i64 17299692549740948006, ; 186: Xamarin.Android.JetBrains.KotlinXSerializationJson => 0xf014dab75ec7ea26 => 16
	i64 17590473451926037903, ; 187: Xamarin.Android.Glide => 0xf41dea67fcfda58f => 14
	i64 17704177640604968747, ; 188: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 57
	i64 17710060891934109755, ; 189: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 55
	i64 17810250014717388575, ; 190: Xamarin.GooglePlayServices.CroNet.dll => 0xf72ab8069020271f => 86
	i64 17869692169643617090, ; 191: Xamarin.GooglePlayServices.CroNet => 0xf7fde659c12feb42 => 86
	i64 17891337867145587222, ; 192: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 88
	i64 17986907704309214542, ; 193: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 85
	i64 18116111925905154859, ; 194: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 25
	i64 18260797123374478311, ; 195: Xamarin.AndroidX.Emoji2 => 0xfd6b623bde35f3e7 => 45
	i64 18296103047334435084, ; 196: storyly.xamarin.binding => 0xfde8d0c8de4f990c => 5
	i64 18380184030268848184 ; 197: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 71
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [198 x i32] [
	i32 42, i32 3, i32 28, i32 65, i32 29, i32 34, i32 54, i32 5, ; 0..7
	i32 84, i32 96, i32 41, i32 97, i32 78, i32 24, i32 22, i32 56, ; 8..15
	i32 50, i32 44, i32 23, i32 65, i32 19, i32 55, i32 60, i32 15, ; 16..23
	i32 26, i32 94, i32 41, i32 64, i32 52, i32 33, i32 69, i32 11, ; 24..31
	i32 18, i32 12, i32 4, i32 66, i32 2, i32 78, i32 51, i32 20, ; 32..39
	i32 10, i32 95, i32 85, i32 67, i32 9, i32 11, i32 63, i32 42, ; 40..47
	i32 34, i32 87, i32 71, i32 53, i32 18, i32 89, i32 83, i32 77, ; 48..55
	i32 58, i32 59, i32 69, i32 68, i32 32, i32 6, i32 21, i32 39, ; 56..63
	i32 73, i32 47, i32 30, i32 74, i32 54, i32 52, i32 0, i32 89, ; 64..71
	i32 26, i32 43, i32 37, i32 79, i32 10, i32 49, i32 15, i32 16, ; 72..79
	i32 13, i32 77, i32 8, i32 0, i32 92, i32 22, i32 98, i32 51, ; 80..87
	i32 1, i32 93, i32 31, i32 53, i32 46, i32 68, i32 76, i32 1, ; 88..95
	i32 91, i32 62, i32 94, i32 73, i32 23, i32 90, i32 9, i32 33, ; 96..103
	i32 75, i32 59, i32 3, i32 30, i32 84, i32 46, i32 43, i32 97, ; 104..111
	i32 8, i32 76, i32 37, i32 88, i32 67, i32 95, i32 35, i32 24, ; 112..119
	i32 21, i32 6, i32 12, i32 79, i32 2, i32 72, i32 29, i32 17, ; 120..127
	i32 36, i32 61, i32 72, i32 74, i32 19, i32 66, i32 83, i32 49, ; 128..135
	i32 70, i32 14, i32 48, i32 57, i32 40, i32 27, i32 28, i32 96, ; 136..143
	i32 38, i32 17, i32 45, i32 70, i32 81, i32 31, i32 82, i32 92, ; 144..151
	i32 25, i32 63, i32 38, i32 91, i32 80, i32 48, i32 80, i32 27, ; 152..159
	i32 60, i32 61, i32 13, i32 64, i32 58, i32 82, i32 36, i32 40, ; 160..167
	i32 62, i32 93, i32 35, i32 56, i32 7, i32 90, i32 44, i32 87, ; 168..175
	i32 7, i32 75, i32 47, i32 39, i32 98, i32 81, i32 32, i32 4, ; 176..183
	i32 20, i32 50, i32 16, i32 14, i32 57, i32 55, i32 86, i32 86, ; 184..191
	i32 88, i32 85, i32 25, i32 45, i32 5, i32 71 ; 192..197
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
