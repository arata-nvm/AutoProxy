﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoProxy.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AutoProxy.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   設定ファイルを作成しました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string CreatedConfigFile {
            get {
                return ResourceManager.GetString("CreatedConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   終了 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ExitMenuItem {
            get {
                return ResourceManager.GetString("ExitMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   設定ファイルの読み込みに失敗しました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string FailedToLoadConfig {
            get {
                return ResourceManager.GetString("FailedToLoadConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   設定ファイルを読み込みました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string LoadedConfigFile {
            get {
                return ResourceManager.GetString("LoadedConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   自動実行を設定しました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string RegisteredAutorun {
            get {
                return ResourceManager.GetString("RegisteredAutorun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   設定再読み込み に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ReloadConfigMenuItem {
            get {
                return ResourceManager.GetString("ReloadConfigMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   自動実行登録 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string SetAutorunMenuItem {
            get {
                return ResourceManager.GetString("SetAutorunMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   プロキシを適用しました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string SetProxy {
            get {
                return ResourceManager.GetString("SetProxy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   自動実行を解除しました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnregisteredAutorun {
            get {
                return ResourceManager.GetString("UnregisteredAutorun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   自動実行解除 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsetAutorunMenuItem {
            get {
                return ResourceManager.GetString("UnsetAutorunMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   プロキシを解除しました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsetProxy {
            get {
                return ResourceManager.GetString("UnsetProxy", resourceCulture);
            }
        }
    }
}
