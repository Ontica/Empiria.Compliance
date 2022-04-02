/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Interface adapters                      *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Data Transfer Object                    *
*  Type     : ProcedureDto                               License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Output DTOs that holds data related to regulatory compliance procedures.                       *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Compliance.Adapters {

  /// <summary>Output DTO that holds full data related to regulatory compliance procedures.</summary>
  public class ProcedureDto {

    public string UID {
      get; internal set;
    }

    public string Code {
      get; internal set;
    }

    public string Name {
      get; internal set;
    }

    public string Description {
      get; internal set;
    }

    public string Topics {
      get; internal set;
    }

    public string Tags {
      get; internal set;
    }

    public string LegalBasis {
      get; internal set;
    }

    public string Regulator {
      get; internal set;
    }

  }  // class ObligationDto



  /// <summary>Output DTO that holds minimal data related to regulatory
  /// compliance procedures to be used within lists.</summary>
  public class ProcedureDescriptorDto {

    public string UID {
      get; internal set;
    }

    public string Code {
      get; internal set;
    }

    public string Name {
      get; internal set;
    }

    public string Topics {
      get; internal set;
    }

    public string Tags {
      get; internal set;
    }

    public string Regulator {
      get; internal set;
    }

  }  // class ObligationDescriptorDto


}  // namespace Empiria.Compliance.Adapters
