/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Interface adapters                      *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Data Transfer Object                    *
*  Type     : ObligationDto                              License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Output DTO that holds full data related to a regulatory compliance obligation.                 *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Compliance.Adapters {

  /// <summary>Output DTO that holds full data related to a regulatory compliance obligation.</summary>
  public class ObligationDto {

    public string UID {
      get; internal set;
    }

    public string Kind {
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



  /// <summary>Output DTO that holds minimal obligation data to be used within lists.</summary>
  public class ObligationDescriptorDto {

    public string UID {
      get; internal set;
    }

    public string Kind {
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
