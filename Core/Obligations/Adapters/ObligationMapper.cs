/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Interface adapters                      *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Mapper class                            *
*  Type     : ObligationMapper                           License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Methods used to map regulatory compliance obligations to their DTOs.                           *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Compliance.Adapters {

  /// <summary>Methods used to map regulatory compliance obligations to their DTOs.</summary>
  static internal class ObligationMapper {

    #region Public methods

    static internal FixedList<ObligationDescriptorDto> Map(FixedList<Obligation> list) {
      var mappedItems = list.Select((x) => MapToDescriptor(x));

      return new FixedList<ObligationDescriptorDto>(mappedItems);
    }


    static internal ObligationDto Map(Obligation obligation) {
      return new ObligationDto {
        UID = obligation.UID,
        Name = obligation.Name,
        Description = obligation.Description,
        Topics = obligation.Topics,
        Tags = obligation.Tags,
        LegalBasis = obligation.LegalBasis,
        Regulator = obligation.Regulator.MapToNamedEntity(),
        Procedure = ProcedureMapper.MapToDescriptor(obligation.Procedure)
      };
    }

    #endregion Public methods

    #region Private methods

    static private ObligationDescriptorDto MapToDescriptor(Obligation obligation) {
      return new ObligationDescriptorDto {
        UID = obligation.UID,
        Name = obligation.Name,
        Topics = obligation.Topics,
        Regulator = obligation.Regulator.Alias
      };
    }

    #endregion Private methods

  }  // class ObligationMapper

}  // namespace Empiria.Compliance.Adapters
