/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Interface adapters                      *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Mapper class                            *
*  Type     : ProcedureMapper                            License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Methods used to map regulatory compliance procedures to their DTOs.                            *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Compliance.Adapters {

  /// <summary>Methods used to map regulatory compliance procedures to their DTOs.</summary>
  static internal class ProcedureMapper {

    #region Public methods

    static internal FixedList<ProcedureDescriptorDto> Map(FixedList<Procedure> list) {
      var mappedItems = list.Select((x) => MapToDescriptor(x));

      return new FixedList<ProcedureDescriptorDto>(mappedItems);
    }


    static internal ProcedureDescriptorDto MapToDescriptor(Procedure procedure) {
      return new ProcedureDescriptorDto {
        UID = procedure.UID,
        Code = procedure.Code,
        Name = procedure.Name,
        Topics = procedure.Topics,
        Regulator = procedure.Regulator.Alias
      };
    }

    #endregion Public methods

  }  // class ProcedureMapper

}  // namespace Empiria.Compliance.Adapters
