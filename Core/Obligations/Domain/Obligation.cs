/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Domain Layer                            *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Empiria Object                          *
*  Type     : Obligation                                 License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Describes a regulatory compliance obligation.                                                  *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Json;
using Empiria.StateEnums;

namespace Empiria.Compliance {

  /// <summary>Describes a regulatory compliance obligation.</summary>
  internal class Obligation : BaseObject {

    #region Constructors and parsers

    protected Obligation() {
      // Required by Empiria Framework for all partitioned types.
    }


    static internal Obligation Parse(int id) {
      return BaseObject.ParseId<Obligation>(id);
    }


    static internal Obligation Parse(string uid) {
      return BaseObject.ParseKey<Obligation>(uid);
    }


    static public Obligation Empty => BaseObject.ParseEmpty<Obligation>();


    #endregion Constructors and parsers

    #region Properties

    [DataField("Name")]
    public string Name {
      get;
      private set;
    }


    [DataField("Description")]
    public string Description {
      get;
      private set;
    }


    [DataField("Tags")]
    public string Tags {
      get;
      private set;
    }


    [DataField("Topics")]
    public string Topics {
      get;
      private set;
    }


    [DataField("RegulatorId")]
    public Regulator Regulator {
      get;
      private set;
    }


    public string LegalBasis {
      get {
        return this.ExtData.Get("LegalBasis", string.Empty);
      }
    }


    [DataField("ProcedureId")]
    public Procedure Procedure {
      get;
      private set;
    }


    public string Keywords {
      get {
        return EmpiriaString.BuildKeywords(this.Name, this.Regulator.Keywords,
                                           this.Topics, this.Tags, this.Description);
      }
    }


    [DataField("Accessibility")]
    public string Accesibility {
      get;
      private set;
    }


    [DataField("ExtData")]
    internal JsonObject ExtData {
      get;
      private set;
    }


    [DataField("DesignStatus", Default = EntityStatus.Pending)]
    public EntityStatus Status {
      get;
      private set;
    } = EntityStatus.Pending;


    #endregion Properties

  }  // class Obligation

}  // namespace Empiria.Compliance
