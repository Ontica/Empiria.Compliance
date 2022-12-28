/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Domain Layer                            *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Empiria Object                          *
*  Type     : Procedure                                  License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Describes a regulatory compliance procedure.                                                   *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Compliance {

  /// <summary>Describes a regulatory compliance procedure.</summary>
  public class Procedure : BaseObject {

    #region Constructors and parsers

    protected Procedure() {
      // Required by Empiria Framework.
    }


    static public Procedure Parse(int id) {
      return BaseObject.ParseId<Procedure>(id);
    }


    static public Procedure Parse(string uid) {
      return BaseObject.ParseKey<Procedure>(uid);
    }


    static public FixedList<Procedure> GetList() {
      return BaseObject.GetList<Procedure>(string.Empty, "ShortName, Code")
                       .ToFixedList();
    }

    static public Procedure Empty => BaseObject.ParseEmpty<Procedure>();


    #endregion Constructors and parsers

    #region Public properties

    [DataField("ProcedureName")]
    public string Name {
      get;
      private set;
    }

    [DataField("ShortName")]
    public string ShortName {
      get;
      private set;
    }


    [DataField("GovName")]
    public string GovName {
      get;
      private set;
    }


    [DataField("Modality")]
    public string Modality {
      get;
      private set;
    }

    [DataField("Code")]
    public string Code {
      get;
      private set;
    }

    [DataField("Notes")]
    public string Notes {
      get;
      private set;
    }


    public string Keywords {
      get {
        return EmpiriaString.BuildKeywords(this.Code, this.ShortName, this.Modality, this.Name, this.GovName,
                                           this.Regulator.FullName, this.Regulator.ShortName, this.ProjectType,
                                           this.Tags, this.Topics, this.Subtopics);
      }
    }


    [DataField("OfficialURL")]
    public string OfficialURL {
      get;
      private set;
    }


    [DataField("RegulationURL")]
    public string RegulationURL {
      get;
      private set;
    }


    [DataField("Theme")]
    public string Topics {
      get;
      private set;
    }


    [DataField("Subtheme")]
    public string Subtopics {
      get;
      private set;
    }


    [DataField("Tags")]
    public string Tags {
      get;
      private set;
    }


    [DataField("ExecutionMode")]
    public string ExecutionMode {
      get;
      private set;
    }

    [DataField("ProjectType")]
    public string ProjectType {
      get;
      private set;
    }


    [DataField("RegulatorId")]
    public Regulator Regulator {
      get;
      private set;
    } = Regulator.Empty;


    #endregion Public properties

  }  // class Procedure

}  // namespace Empiria.Compliance
