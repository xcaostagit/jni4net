//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime.process {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface WorkItemManager {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JLjava/util/Map;)V")]
        void completeWorkItem(long par0, global::java.util.Map par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        void abortWorkItem(long par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Lorg/drools/runtime/process/WorkItemHandler;)V")]
        void registerWorkItemHandler(global::java.lang.String par0, global::org.drools.runtime.process.WorkItemHandler par1);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class WorkItemManager_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.process.@__WorkItemManager.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.runtime.process.WorkItemManager), typeof(global::org.drools.runtime.process.WorkItemManager_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.runtime.process.WorkItemManager), typeof(global::org.drools.runtime.process.WorkItemManager_))]
    internal sealed partial class @__WorkItemManager : global::java.lang.Object, global::org.drools.runtime.process.WorkItemManager {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _completeWorkItem0;
        
        internal static global::net.sf.jni4net.jni.MethodId _abortWorkItem1;
        
        internal static global::net.sf.jni4net.jni.MethodId _registerWorkItemHandler2;
        
        private @__WorkItemManager(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.process.@__WorkItemManager.staticClass = @__class;
            global::org.drools.runtime.process.@__WorkItemManager._completeWorkItem0 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItemManager.staticClass, "completeWorkItem", "(JLjava/util/Map;)V");
            global::org.drools.runtime.process.@__WorkItemManager._abortWorkItem1 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItemManager.staticClass, "abortWorkItem", "(J)V");
            global::org.drools.runtime.process.@__WorkItemManager._registerWorkItemHandler2 = @__env.GetMethodID(global::org.drools.runtime.process.@__WorkItemManager.staticClass, "registerWorkItemHandler", "(Ljava/lang/String;Lorg/drools/runtime/process/WorkItemHandler;)V");
        }
        
        public void completeWorkItem(long par0, global::java.util.Map par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.process.@__WorkItemManager._completeWorkItem0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Map>(@__env, par1));
            }
        }
        
        public void abortWorkItem(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.process.@__WorkItemManager._abortWorkItem1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        public void registerWorkItemHandler(global::java.lang.String par0, global::org.drools.runtime.process.WorkItemHandler par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.process.@__WorkItemManager._registerWorkItemHandler2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.process.WorkItemHandler>(@__env, par1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__WorkItemManager);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "completeWorkItem", "completeWorkItem0", "(JLjava/util/Map;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "abortWorkItem", "abortWorkItem1", "(J)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "registerWorkItemHandler", "registerWorkItemHandler2", "(Ljava/lang/String;Lorg/drools/runtime/process/WorkItemHandler;)V"));
            return methods;
        }
        
        private static void completeWorkItem0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, long par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (JLjava/util/Map;)V
            // (JLjava/util/Map;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.process.WorkItemManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItemManager>(@__env, @__obj);
            @__real.completeWorkItem(par0, global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void abortWorkItem1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, long par0) {
            // (J)V
            // (J)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.process.WorkItemManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItemManager>(@__env, @__obj);
            @__real.abortWorkItem(par0);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void registerWorkItemHandler2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/String;Lorg/drools/runtime/process/WorkItemHandler;)V
            // (Ljava/lang/String;Lorg/drools/runtime/process/WorkItemHandler;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.process.WorkItemManager @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItemManager>(@__env, @__obj);
            @__real.registerWorkItemHandler(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.process.WorkItemHandler>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.process.@__WorkItemManager(@__env);
            }
        }
    }
    #endregion
}
