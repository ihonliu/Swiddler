﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Swiddler.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Swiddler.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] netprobe32 {
            get {
                object obj = ResourceManager.GetObject("netprobe32", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] netprobe64 {
            get {
                object obj = ResourceManager.GetObject("netprobe64", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1,tcpmux
        ///2,compressnet
        ///3,compressnet
        ///5,rje
        ///7,echo
        ///9,discard
        ///11,systat
        ///13,daytime
        ///17,qotd
        ///18,msp
        ///19,chargen
        ///20,ftp-data
        ///21,ftp
        ///22,ssh
        ///23,telnet
        ///25,smtp
        ///27,nsw-fe
        ///29,msg-icp
        ///31,msg-auth
        ///33,dsp
        ///37,time
        ///38,rap
        ///39,rlp
        ///41,graphics
        ///42,name
        ///43,nicname
        ///44,mpm-flags
        ///45,mpm
        ///46,mpm-snd
        ///48,auditd
        ///49,tacacs
        ///50,re-mail-ck
        ///52,xns-time
        ///53,domain
        ///54,xns-ch
        ///55,isi-gl
        ///56,xns-auth
        ///58,xns-mail
        ///62,acas
        ///63,whoispp
        ///64,covia
        ///65,tacacs-ds
        ///66,sql-net
        ///67,bootps
        ///68,bootpc
        ///69,tftp
        ///70,gopher
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string port_numbers {
            get {
                return ResourceManager.GetString("port_numbers", resourceCulture);
            }
        }
    }
}
