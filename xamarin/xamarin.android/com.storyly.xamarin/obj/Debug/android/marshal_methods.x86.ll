; ModuleID = 'obj/Debug/android/marshal_methods.x86.ll'
source_filename = "obj/Debug/android/marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [198 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 54
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 82
	i32 75499283, ; 2: Xamarin.Android.JetBrains.KotlinXSerializationJson => 0x4800713 => 16
	i32 165246403, ; 3: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 28
	i32 209399409, ; 4: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 26
	i32 230216969, ; 5: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 50
	i32 261689757, ; 6: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 32
	i32 266337479, ; 7: Xamarin.Google.Guava.FailureAccess.dll => 0xfdffcc7 => 81
	i32 280482487, ; 8: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 49
	i32 284879154, ; 9: Xamarin.Android.JetBrains.KotlinXSerializationJson.dll => 0x10fae932 => 16
	i32 318968648, ; 10: Xamarin.AndroidX.Activity.dll => 0x13031348 => 18
	i32 321597661, ; 11: System.Numerics => 0x132b30dd => 9
	i32 342366114, ; 12: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 51
	i32 401610494, ; 13: Xamarin.AndroidX.Emoji => 0x17f016fe => 44
	i32 441335492, ; 14: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 31
	i32 442521989, ; 15: Xamarin.Essentials => 0x1a605985 => 77
	i32 450948140, ; 16: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 48
	i32 465846621, ; 17: mscorlib => 0x1bc4415d => 4
	i32 469710990, ; 18: System.dll => 0x1bff388e => 7
	i32 473777085, ; 19: Xamarin.CheckerFramework.CheckerCompatQual.dll => 0x1c3d43bd => 74
	i32 476646585, ; 20: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 49
	i32 486930444, ; 21: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 58
	i32 557405415, ; 22: Jsr305Binding => 0x213954e7 => 2
	i32 627609679, ; 23: Xamarin.AndroidX.CustomView => 0x2568904f => 37
	i32 639843206, ; 24: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 46
	i32 663517072, ; 25: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 71
	i32 666292255, ; 26: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 24
	i32 691348768, ; 27: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 93
	i32 700284507, ; 28: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 88
	i32 745372456, ; 29: Xamarin.AndroidX.Emoji.AppCompat => 0x2c6d7b28 => 43
	i32 763245950, ; 30: com.storyly.xamarin.dll => 0x2d7e357e => 0
	i32 790371945, ; 31: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 38
	i32 809851609, ; 32: System.Drawing.Common.dll => 0x30455ad9 => 96
	i32 843511501, ; 33: Xamarin.AndroidX.Print => 0x3246f6cd => 61
	i32 928116545, ; 34: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 82
	i32 967690846, ; 35: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 51
	i32 1012816738, ; 36: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 65
	i32 1031528504, ; 37: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 79
	i32 1035644815, ; 38: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 23
	i32 1052210849, ; 39: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 55
	i32 1084122840, ; 40: Xamarin.Kotlin.StdLib => 0x409e66d8 => 92
	i32 1098259244, ; 41: System => 0x41761b2c => 7
	i32 1111591002, ; 42: Xamarin.CodeHaus.Mojo.AnimalSnifferAnnotations => 0x4241885a => 76
	i32 1175144683, ; 43: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 69
	i32 1204270330, ; 44: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 24
	i32 1246548578, ; 45: Xamarin.AndroidX.Collection.Jvm.dll => 0x4a4cd262 => 29
	i32 1263886435, ; 46: Xamarin.Google.Guava.dll => 0x4b556063 => 80
	i32 1264511973, ; 47: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 66
	i32 1264890200, ; 48: Xamarin.KotlinX.Coroutines.Core.dll => 0x4b64b158 => 94
	i32 1267360935, ; 49: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 70
	i32 1275534314, ; 50: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 93
	i32 1278448581, ; 51: Xamarin.AndroidX.Annotation.Jvm => 0x4c3393c5 => 21
	i32 1293217323, ; 52: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 41
	i32 1376866003, ; 53: Xamarin.AndroidX.SavedState => 0x52114ed3 => 65
	i32 1380089069, ; 54: Xamarin.Google.J2Objc.Annotations.dll => 0x52427ced => 83
	i32 1395857551, ; 55: Xamarin.AndroidX.Media.dll => 0x5333188f => 59
	i32 1406073936, ; 56: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 33
	i32 1406299041, ; 57: Xamarin.Google.Guava.FailureAccess => 0x53d26ba1 => 81
	i32 1469204771, ; 58: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 22
	i32 1582372066, ; 59: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 40
	i32 1597949149, ; 60: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 79
	i32 1622152042, ; 61: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 57
	i32 1624863272, ; 62: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 73
	i32 1635184631, ; 63: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 46
	i32 1636350590, ; 64: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 36
	i32 1639515021, ; 65: System.Net.Http.dll => 0x61b9038d => 8
	i32 1657153582, ; 66: System.Runtime => 0x62c6282e => 11
	i32 1658241508, ; 67: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 67
	i32 1658251792, ; 68: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 78
	i32 1670060433, ; 69: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 32
	i32 1698840827, ; 70: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 91
	i32 1729485958, ; 71: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 27
	i32 1776026572, ; 72: System.Core.dll => 0x69dc03cc => 6
	i32 1788241197, ; 73: Xamarin.AndroidX.Fragment => 0x6a96652d => 48
	i32 1808609942, ; 74: Xamarin.AndroidX.Loader => 0x6bcd3296 => 57
	i32 1813058853, ; 75: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 92
	i32 1813201214, ; 76: Xamarin.Google.Android.Material => 0x6c13413e => 78
	i32 1867746548, ; 77: Xamarin.Essentials.dll => 0x6f538cf4 => 77
	i32 1873787912, ; 78: Xamarin.AndroidX.DataBinding.ViewBinding.dll => 0x6fafbc08 => 39
	i32 1885316902, ; 79: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 25
	i32 1908813208, ; 80: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 85
	i32 1919157823, ; 81: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 60
	i32 1983156543, ; 82: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 91
	i32 1985761444, ; 83: Xamarin.Android.Glide.GifDecoder => 0x765c50a4 => 15
	i32 2000917853, ; 84: Xamarin.JetBrains.KotlinXSerializationJsonJvm => 0x7743955d => 90
	i32 2019465201, ; 85: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 55
	i32 2031763787, ; 86: Xamarin.Android.Glide => 0x791a414b => 14
	i32 2055257422, ; 87: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 52
	i32 2079903147, ; 88: System.Runtime.dll => 0x7bf8cdab => 11
	i32 2090596640, ; 89: System.Numerics.Vectors => 0x7c9bf920 => 10
	i32 2108858335, ; 90: Xamarin.CheckerFramework.CheckerCompatQual => 0x7db29fdf => 74
	i32 2129483829, ; 91: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 84
	i32 2201107256, ; 92: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 95
	i32 2201231467, ; 93: System.Net.Http => 0x8334206b => 8
	i32 2217644978, ; 94: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 69
	i32 2244775296, ; 95: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 58
	i32 2256548716, ; 96: Xamarin.AndroidX.MultiDex => 0x8680336c => 60
	i32 2267999099, ; 97: Xamarin.Android.Glide.DiskLruCache.dll => 0x872eeb7b => 13
	i32 2279755925, ; 98: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 63
	i32 2315684594, ; 99: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 19
	i32 2403452196, ; 100: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 45
	i32 2465532216, ; 101: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 31
	i32 2475788418, ; 102: Java.Interop.dll => 0x93918882 => 1
	i32 2483485473, ; 103: Xamarin.Android.Volley.dll => 0x9406fb21 => 17
	i32 2505896520, ; 104: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 54
	i32 2522472828, ; 105: Xamarin.Android.Glide.dll => 0x9659e17c => 14
	i32 2581819634, ; 106: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 70
	i32 2605712449, ; 107: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 95
	i32 2620871830, ; 108: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 36
	i32 2624644809, ; 109: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 42
	i32 2652665316, ; 110: Xamarin.CodeHaus.Mojo.AnimalSnifferAnnotations.dll => 0x9e1c75e4 => 76
	i32 2663391936, ; 111: Xamarin.Android.Glide.DiskLruCache => 0x9ec022c0 => 13
	i32 2671474046, ; 112: Xamarin.KotlinX.Coroutines.Core => 0x9f3b757e => 94
	i32 2701096212, ; 113: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 67
	i32 2732626843, ; 114: Xamarin.AndroidX.Activity => 0xa2e0939b => 18
	i32 2737747696, ; 115: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 22
	i32 2770495804, ; 116: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 88
	i32 2773678566, ; 117: Xamarin.AndroidX.DataBinding.ViewBinding => 0xa552f9e6 => 39
	i32 2778768386, ; 118: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 72
	i32 2779977773, ; 119: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 64
	i32 2810250172, ; 120: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 33
	i32 2819470561, ; 121: System.Xml.dll => 0xa80db4e1 => 12
	i32 2821294376, ; 122: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 64
	i32 2825501188, ; 123: Xamarin.AndroidX.Emoji.AppCompat.dll => 0xa869ba04 => 43
	i32 2847418871, ; 124: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 84
	i32 2853208004, ; 125: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 72
	i32 2855708567, ; 126: Xamarin.AndroidX.Transition => 0xaa36a797 => 68
	i32 2875164099, ; 127: Jsr305Binding.dll => 0xab5f85c3 => 2
	i32 2884993177, ; 128: Xamarin.AndroidX.ExifInterface => 0xabf58099 => 47
	i32 2903344695, ; 129: System.ComponentModel.Composition => 0xad0d8637 => 98
	i32 2905242038, ; 130: mscorlib.dll => 0xad2a79b6 => 4
	i32 2916838712, ; 131: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 73
	i32 2919462931, ; 132: System.Numerics.Vectors.dll => 0xae037813 => 10
	i32 2921128767, ; 133: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 20
	i32 2960379616, ; 134: Xamarin.Google.Guava => 0xb073cee0 => 80
	i32 2978675010, ; 135: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 41
	i32 2996846495, ; 136: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 53
	i32 3016983068, ; 137: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 66
	i32 3024354802, ; 138: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 50
	i32 3042628226, ; 139: Xamarin.JetBrains.KotlinXSerializationJsonJvm.dll => 0xb55ad282 => 90
	i32 3058099980, ; 140: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 87
	i32 3150893199, ; 141: com.storyly.xamarin => 0xbbced08f => 0
	i32 3164032125, ; 142: Xamarin.GooglePlayServices.CroNet => 0xbc974c7d => 86
	i32 3211777861, ; 143: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 40
	i32 3230466174, ; 144: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 85
	i32 3247949154, ; 145: Mono.Security => 0xc197c562 => 97
	i32 3258312781, ; 146: Xamarin.AndroidX.CardView => 0xc235e84d => 27
	i32 3282912816, ; 147: Xamarin.AndroidX.Emoji.dll => 0xc3ad4630 => 44
	i32 3288575774, ; 148: Xamarin.JetBrains.KotlinXSerializationCoreJvm => 0xc403af1e => 89
	i32 3317135071, ; 149: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 37
	i32 3340431453, ; 150: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 25
	i32 3345895724, ; 151: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 62
	i32 3362522851, ; 152: Xamarin.AndroidX.Core => 0xc86c06e3 => 35
	i32 3366347497, ; 153: Java.Interop => 0xc8a662e9 => 1
	i32 3374999561, ; 154: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 63
	i32 3405233483, ; 155: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 38
	i32 3415702302, ; 156: Xamarin.Chromium.CroNet.Api => 0xcb977b1e => 75
	i32 3429136800, ; 157: System.Xml => 0xcc6479a0 => 12
	i32 3441283291, ; 158: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 42
	i32 3476120550, ; 159: Mono.Android => 0xcf3163e6 => 3
	i32 3493954962, ; 160: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 30
	i32 3567349600, ; 161: System.ComponentModel.Composition.dll => 0xd4a16f60 => 98
	i32 3597029428, ; 162: Xamarin.Android.Glide.GifDecoder.dll => 0xd6665034 => 15
	i32 3627220390, ; 163: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 61
	i32 3633644679, ; 164: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 20
	i32 3641597786, ; 165: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 52
	i32 3672681054, ; 166: Mono.Android.dll => 0xdae8aa5e => 3
	i32 3682565725, ; 167: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 26
	i32 3684561358, ; 168: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 30
	i32 3689375977, ; 169: System.Drawing.Common => 0xdbe768e9 => 96
	i32 3706696989, ; 170: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 34
	i32 3718780102, ; 171: Xamarin.AndroidX.Annotation => 0xdda814c6 => 19
	i32 3762494075, ; 172: Xamarin.Chromium.CroNet.Api.dll => 0xe0431a7b => 75
	i32 3786282454, ; 173: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 28
	i32 3822602673, ; 174: Xamarin.AndroidX.Media => 0xe3d849b1 => 59
	i32 3829621856, ; 175: System.Numerics.dll => 0xe4436460 => 9
	i32 3831603066, ; 176: Xamarin.GooglePlayServices.CroNet.dll => 0xe4619f7a => 86
	i32 3861642143, ; 177: storyly.xamarin.binding.dll => 0xe62bfb9f => 5
	i32 3885922214, ; 178: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 68
	i32 3888767677, ; 179: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 62
	i32 3896760992, ; 180: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 35
	i32 3910130544, ; 181: Xamarin.AndroidX.Collection.Jvm => 0xe90fdb70 => 29
	i32 3921031405, ; 182: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 71
	i32 3955647286, ; 183: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 23
	i32 3959773229, ; 184: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 53
	i32 3970018735, ; 185: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 87
	i32 4015948917, ; 186: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 21
	i32 4019831827, ; 187: storyly.xamarin.binding => 0xef99c413 => 5
	i32 4042068492, ; 188: Xamarin.Google.J2Objc.Annotations => 0xf0ed120c => 83
	i32 4070859669, ; 189: Xamarin.Android.Volley => 0xf2a46395 => 17
	i32 4074714767, ; 190: Xamarin.JetBrains.KotlinXSerializationCoreJvm.dll => 0xf2df368f => 89
	i32 4101593132, ; 191: Xamarin.AndroidX.Emoji2 => 0xf479582c => 45
	i32 4105002889, ; 192: Mono.Security.dll => 0xf4ad5f89 => 97
	i32 4151237749, ; 193: System.Core => 0xf76edc75 => 6
	i32 4182413190, ; 194: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 56
	i32 4256097574, ; 195: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 34
	i32 4292120959, ; 196: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 56
	i32 4294763496 ; 197: Xamarin.AndroidX.ExifInterface.dll => 0xfffce3e8 => 47
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [198 x i32] [
	i32 54, i32 82, i32 16, i32 28, i32 26, i32 50, i32 32, i32 81, ; 0..7
	i32 49, i32 16, i32 18, i32 9, i32 51, i32 44, i32 31, i32 77, ; 8..15
	i32 48, i32 4, i32 7, i32 74, i32 49, i32 58, i32 2, i32 37, ; 16..23
	i32 46, i32 71, i32 24, i32 93, i32 88, i32 43, i32 0, i32 38, ; 24..31
	i32 96, i32 61, i32 82, i32 51, i32 65, i32 79, i32 23, i32 55, ; 32..39
	i32 92, i32 7, i32 76, i32 69, i32 24, i32 29, i32 80, i32 66, ; 40..47
	i32 94, i32 70, i32 93, i32 21, i32 41, i32 65, i32 83, i32 59, ; 48..55
	i32 33, i32 81, i32 22, i32 40, i32 79, i32 57, i32 73, i32 46, ; 56..63
	i32 36, i32 8, i32 11, i32 67, i32 78, i32 32, i32 91, i32 27, ; 64..71
	i32 6, i32 48, i32 57, i32 92, i32 78, i32 77, i32 39, i32 25, ; 72..79
	i32 85, i32 60, i32 91, i32 15, i32 90, i32 55, i32 14, i32 52, ; 80..87
	i32 11, i32 10, i32 74, i32 84, i32 95, i32 8, i32 69, i32 58, ; 88..95
	i32 60, i32 13, i32 63, i32 19, i32 45, i32 31, i32 1, i32 17, ; 96..103
	i32 54, i32 14, i32 70, i32 95, i32 36, i32 42, i32 76, i32 13, ; 104..111
	i32 94, i32 67, i32 18, i32 22, i32 88, i32 39, i32 72, i32 64, ; 112..119
	i32 33, i32 12, i32 64, i32 43, i32 84, i32 72, i32 68, i32 2, ; 120..127
	i32 47, i32 98, i32 4, i32 73, i32 10, i32 20, i32 80, i32 41, ; 128..135
	i32 53, i32 66, i32 50, i32 90, i32 87, i32 0, i32 86, i32 40, ; 136..143
	i32 85, i32 97, i32 27, i32 44, i32 89, i32 37, i32 25, i32 62, ; 144..151
	i32 35, i32 1, i32 63, i32 38, i32 75, i32 12, i32 42, i32 3, ; 152..159
	i32 30, i32 98, i32 15, i32 61, i32 20, i32 52, i32 3, i32 26, ; 160..167
	i32 30, i32 96, i32 34, i32 19, i32 75, i32 28, i32 59, i32 9, ; 168..175
	i32 86, i32 5, i32 68, i32 62, i32 35, i32 29, i32 71, i32 23, ; 176..183
	i32 53, i32 87, i32 21, i32 5, i32 83, i32 17, i32 89, i32 45, ; 184..191
	i32 97, i32 6, i32 56, i32 34, i32 56, i32 47 ; 192..197
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
