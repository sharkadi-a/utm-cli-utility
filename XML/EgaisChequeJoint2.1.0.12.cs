//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Этот исходный код был создан с помощью xsd, версия=4.0.30319.33440.
// 

namespace UtmCliUtility.XML
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Bottle
    {

        private string priceField;

        private string barcodeField;

        private string eanField;

        private string volumeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string price
        {
            get { return this.priceField; }
            set { this.priceField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string barcode
        {
            get { return this.barcodeField; }
            set { this.barcodeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ean
        {
            get { return this.eanField; }
            set { this.eanField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string volume
        {
            get { return this.volumeField; }
            set { this.volumeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class nopdf
    {

        private string codeField;

        private string priceField;

        private string bnameField;

        private string alcField;

        private string volumeField;

        private string eanField;

        private string countField;

        private string alccodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string price
        {
            get { return this.priceField; }
            set { this.priceField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bname
        {
            get { return this.bnameField; }
            set { this.bnameField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alc
        {
            get { return this.alcField; }
            set { this.alcField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string volume
        {
            get { return this.volumeField; }
            set { this.volumeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ean
        {
            get { return this.eanField; }
            set { this.eanField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string count
        {
            get { return this.countField; }
            set { this.countField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alccode
        {
            get { return this.alccodeField; }
            set { this.alccodeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Cheque
    {

        private object[] itemsField;

        private string innField;

        private string kppField;

        private string addressField;

        private string nameField;

        private string kassaField;

        private string shiftField;

        private string numberField;

        private string datetimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Bottle", typeof (Bottle))]
        [System.Xml.Serialization.XmlElementAttribute("nopdf", typeof (nopdf))]
        public object[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inn
        {
            get { return this.innField; }
            set { this.innField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string kpp
        {
            get { return this.kppField; }
            set { this.kppField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string kassa
        {
            get { return this.kassaField; }
            set { this.kassaField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string shift
        {
            get { return this.shiftField; }
            set { this.shiftField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string number
        {
            get { return this.numberField; }
            set { this.numberField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datetime
        {
            get { return this.datetimeField; }
            set { this.datetimeField = value; }
        }
    }
}