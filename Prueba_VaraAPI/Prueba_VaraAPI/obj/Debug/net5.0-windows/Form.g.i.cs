// Updated by XamlIntelliSenseFileGenerator 20/11/2021 06:23:32 p. m.
#pragma checksum "..\..\..\Form.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "322C32709001105329FF85B6F697B816AD11BACC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Prueba_VaraAPI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Prueba_VaraAPI
{


    /// <summary>
    /// Form
    /// </summary>
    public partial class Form : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Prueba_VaraAPI;component/form.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Form.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 63 "..\..\..\Form.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox infoNom;
        internal System.Windows.Controls.TextBox infoTel;
        internal System.Windows.Controls.TextBox infoDir;
        internal System.Windows.Controls.ComboBox ordenAnimal;
        internal System.Windows.Controls.ComboBox condicionAnimal;
        internal System.Windows.Controls.TextBox numAnimales;
        internal System.Windows.Controls.TextBox observaciones;
        internal System.Windows.Controls.ComboBox sustrato;
        internal System.Windows.Controls.ComboBox primeraVisto;
        internal System.Windows.Controls.TextBox ciudad;
        internal System.Windows.Controls.TextBox localidad;
        internal System.Windows.Controls.TextBox longitud;
        internal System.Windows.Controls.TextBox latitud;
        internal System.Windows.Controls.TextBox infoAdicional;
        internal System.Windows.Controls.TextBox estado;
        internal System.Windows.Controls.TextBox pais;
        internal System.Windows.Controls.TextBox fechaAvistamiento;
        internal System.Windows.Controls.CheckBox facilAccessoCB;
        internal System.Windows.Controls.CheckBox acantiladoCB;
    }
}

