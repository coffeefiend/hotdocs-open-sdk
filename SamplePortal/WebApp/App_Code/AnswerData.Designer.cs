﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/AnswerData.xsd")]
public partial class AnswerData {
    
    private AnswerDataAnswers[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Answers")]
    public AnswerDataAnswers[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/AnswerData.xsd")]
public partial class AnswerDataAnswers {
    
    private string filenameField;
    
    private string titleField;
    
    private string descriptionField;
    
    private System.DateTime dateCreatedField;
    
    private bool dateCreatedFieldSpecified;
    
    private System.DateTime lastModifiedField;
    
    private bool lastModifiedFieldSpecified;
    
    /// <remarks/>
    public string Filename {
        get {
            return this.filenameField;
        }
        set {
            this.filenameField = value;
        }
    }
    
    /// <remarks/>
    public string Title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime DateCreated {
        get {
            return this.dateCreatedField;
        }
        set {
            this.dateCreatedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DateCreatedSpecified {
        get {
            return this.dateCreatedFieldSpecified;
        }
        set {
            this.dateCreatedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime LastModified {
        get {
            return this.lastModifiedField;
        }
        set {
            this.lastModifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LastModifiedSpecified {
        get {
            return this.lastModifiedFieldSpecified;
        }
        set {
            this.lastModifiedFieldSpecified = value;
        }
    }
}
