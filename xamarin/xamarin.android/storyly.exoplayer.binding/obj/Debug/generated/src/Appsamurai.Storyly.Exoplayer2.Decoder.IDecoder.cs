using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Appsamurai.Storyly.Exoplayer2.Decoder {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.appsamurai.storyly.exoplayer2.decoder']/interface[@name='Decoder']"
	[Register ("com/appsamurai/storyly/exoplayer2/decoder/Decoder", "", "Appsamurai.Storyly.Exoplayer2.Decoder.IDecoderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"I", "O", "E extends com.appsamurai.storyly.exoplayer2.decoder.DecoderException"})]
	public partial interface IDecoder : IJavaObject, IJavaPeerable {
		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.exoplayer2.decoder']/interface[@name='Decoder']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Appsamurai.Storyly.Exoplayer2.Decoder.IDecoderInvoker, storyly.exoplayer.binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.exoplayer2.decoder']/interface[@name='Decoder']/method[@name='dequeueInputBuffer' and count(parameter)=0]"
		[Register ("dequeueInputBuffer", "()Ljava/lang/Object;", "GetDequeueInputBufferHandler:Appsamurai.Storyly.Exoplayer2.Decoder.IDecoderInvoker, storyly.exoplayer.binding")]
		global::Java.Lang.Object DequeueInputBuffer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.exoplayer2.decoder']/interface[@name='Decoder']/method[@name='dequeueOutputBuffer' and count(parameter)=0]"
		[Register ("dequeueOutputBuffer", "()Ljava/lang/Object;", "GetDequeueOutputBufferHandler:Appsamurai.Storyly.Exoplayer2.Decoder.IDecoderInvoker, storyly.exoplayer.binding")]
		global::Java.Lang.Object DequeueOutputBuffer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.exoplayer2.decoder']/interface[@name='Decoder']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Appsamurai.Storyly.Exoplayer2.Decoder.IDecoderInvoker, storyly.exoplayer.binding")]
		void Flush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.exoplayer2.decoder']/interface[@name='Decoder']/method[@name='queueInputBuffer' and count(parameter)=1 and parameter[1][@type='I']]"
		[Register ("queueInputBuffer", "(Ljava/lang/Object;)V", "GetQueueInputBuffer_Ljava_lang_Object_Handler:Appsamurai.Storyly.Exoplayer2.Decoder.IDecoderInvoker, storyly.exoplayer.binding")]
		void QueueInputBuffer (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.appsamurai.storyly.exoplayer2.decoder']/interface[@name='Decoder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Appsamurai.Storyly.Exoplayer2.Decoder.IDecoderInvoker, storyly.exoplayer.binding")]
		void Release ();

	}

	[global::Android.Runtime.Register ("com/appsamurai/storyly/exoplayer2/decoder/Decoder", DoNotGenerateAcw=true)]
	internal partial class IDecoderInvoker : global::Java.Lang.Object, IDecoder {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/appsamurai/storyly/exoplayer2/decoder/Decoder", typeof (IDecoderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDecoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.appsamurai.storyly.exoplayer2.decoder.Decoder'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetName));
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Appsamurai.Storyly.Exoplayer2.Decoder.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_dequeueInputBuffer;
#pragma warning disable 0169
		static Delegate GetDequeueInputBufferHandler ()
		{
			if (cb_dequeueInputBuffer == null)
				cb_dequeueInputBuffer = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DequeueInputBuffer));
			return cb_dequeueInputBuffer;
		}

		static IntPtr n_DequeueInputBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Appsamurai.Storyly.Exoplayer2.Decoder.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DequeueInputBuffer ());
		}
#pragma warning restore 0169

		IntPtr id_dequeueInputBuffer;
		public unsafe global::Java.Lang.Object DequeueInputBuffer ()
		{
			if (id_dequeueInputBuffer == IntPtr.Zero)
				id_dequeueInputBuffer = JNIEnv.GetMethodID (class_ref, "dequeueInputBuffer", "()Ljava/lang/Object;");
			return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dequeueInputBuffer), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_dequeueOutputBuffer;
#pragma warning disable 0169
		static Delegate GetDequeueOutputBufferHandler ()
		{
			if (cb_dequeueOutputBuffer == null)
				cb_dequeueOutputBuffer = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DequeueOutputBuffer));
			return cb_dequeueOutputBuffer;
		}

		static IntPtr n_DequeueOutputBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Appsamurai.Storyly.Exoplayer2.Decoder.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DequeueOutputBuffer ());
		}
#pragma warning restore 0169

		IntPtr id_dequeueOutputBuffer;
		public unsafe global::Java.Lang.Object DequeueOutputBuffer ()
		{
			if (id_dequeueOutputBuffer == IntPtr.Zero)
				id_dequeueOutputBuffer = JNIEnv.GetMethodID (class_ref, "dequeueOutputBuffer", "()Ljava/lang/Object;");
			return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dequeueOutputBuffer), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Flush));
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Appsamurai.Storyly.Exoplayer2.Decoder.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		IntPtr id_flush;
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
		}

		static Delegate cb_queueInputBuffer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetQueueInputBuffer_Ljava_lang_Object_Handler ()
		{
			if (cb_queueInputBuffer_Ljava_lang_Object_ == null)
				cb_queueInputBuffer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_QueueInputBuffer_Ljava_lang_Object_));
			return cb_queueInputBuffer_Ljava_lang_Object_;
		}

		static void n_QueueInputBuffer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Appsamurai.Storyly.Exoplayer2.Decoder.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QueueInputBuffer (p0);
		}
#pragma warning restore 0169

		IntPtr id_queueInputBuffer_Ljava_lang_Object_;
		public unsafe void QueueInputBuffer (global::Java.Lang.Object p0)
		{
			if (id_queueInputBuffer_Ljava_lang_Object_ == IntPtr.Zero)
				id_queueInputBuffer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "queueInputBuffer", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queueInputBuffer_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Release));
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Appsamurai.Storyly.Exoplayer2.Decoder.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

	}
}
