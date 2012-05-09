﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
    #region Range Permission

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_ProofErr
    {

    
        spellStart,

    
        spellEnd,

    
        gramStart,

    
        gramEnd,
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CT_PermStart))]

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Perm
    {

        private string idField;

        private ST_DisplacedByCustomXml displacedByCustomXmlField;

        private bool displacedByCustomXmlFieldSpecified;

        // TODO is the following correct/better with regard the namespace?
        //[XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_DisplacedByCustomXml displacedByCustomXml
        {
            get
            {
                return this.displacedByCustomXmlField;
            }
            set
            {
                this.displacedByCustomXmlField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool displacedByCustomXmlSpecified
        {
            get
            {
                return this.displacedByCustomXmlFieldSpecified;
            }
            set
            {
                this.displacedByCustomXmlFieldSpecified = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_PermStart : CT_Perm
    {

        private ST_EdGrp edGrpField;

        private bool edGrpFieldSpecified;

        private string edField;

        private string colFirstField;

        private string colLastField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_EdGrp edGrp
        {
            get
            {
                return this.edGrpField;
            }
            set
            {
                this.edGrpField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool edGrpSpecified
        {
            get
            {
                return this.edGrpFieldSpecified;
            }
            set
            {
                this.edGrpFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ed
        {
            get
            {
                return this.edField;
            }
            set
            {
                this.edField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string colFirst
        {
            get
            {
                return this.colFirstField;
            }
            set
            {
                this.colFirstField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
        public string colLast
        {
            get
            {
                return this.colLastField;
            }
            set
            {
                this.colLastField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_EdGrp
    {

    
        none,

    
        everyone,

    
        administrators,

    
        contributors,

    
        editors,

    
        owners,

    
        current,
    }
    #endregion

}