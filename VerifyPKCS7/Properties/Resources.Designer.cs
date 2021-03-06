﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VerifyPKCS7.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VerifyPKCS7.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Digest Algorithm: .
        /// </summary>
        internal static string CertDigestAlgorithm {
            get {
                return ResourceManager.GetString("CertDigestAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Issuer: .
        /// </summary>
        internal static string CertIssuer {
            get {
                return ResourceManager.GetString("CertIssuer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Valid until: .
        /// </summary>
        internal static string CertNotAfter {
            get {
                return ResourceManager.GetString("CertNotAfter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Valid from: .
        /// </summary>
        internal static string CertNotBefore {
            get {
                return ResourceManager.GetString("CertNotBefore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Serial: .
        /// </summary>
        internal static string CertSerial {
            get {
                return ResourceManager.GetString("CertSerial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subject: .
        /// </summary>
        internal static string CertSubject {
            get {
                return ResourceManager.GetString("CertSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fingerprint: .
        /// </summary>
        internal static string CertThumb {
            get {
                return ResourceManager.GetString("CertThumb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown certificate data specifier: .
        /// </summary>
        internal static string CertUnk {
            get {
                return ResourceManager.GetString("CertUnk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} longer than {1} bytes..
        /// </summary>
        internal static string FileTooLong {
            get {
                return ResourceManager.GetString("FileTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Goldkey {
            get {
                object obj = ResourceManager.GetObject("Goldkey", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Greenkey {
            get {
                object obj = ResourceManager.GetObject("Greenkey", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hash checked...
        /// </summary>
        internal static string HashChecked {
            get {
                return ResourceManager.GetString("HashChecked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message decoded...
        /// </summary>
        internal static string MessageDecoded {
            get {
                return ResourceManager.GetString("MessageDecoded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Redkey {
            get {
                object obj = ResourceManager.GetObject("Redkey", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature certificate validated..
        /// </summary>
        internal static string SignatureCertChecked {
            get {
                return ResourceManager.GetString("SignatureCertChecked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature checked...
        /// </summary>
        internal static string SignatureChecked {
            get {
                return ResourceManager.GetString("SignatureChecked", resourceCulture);
            }
        }
    }
}
