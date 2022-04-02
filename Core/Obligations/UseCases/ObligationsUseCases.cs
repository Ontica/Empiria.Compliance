/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Use cases Layer                         *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Use case interactor class               *
*  Type     : ObligationsUseCases                        License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Use cases for regulatory compliance obligations.                                               *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Services;

using Empiria.Compliance.Data;
using Empiria.Compliance.Adapters;

namespace Empiria.Compliance.UseCases {

  /// <summary>Use cases for regulatory compliance obligations.</summary>
  public class ObligationsUseCases : UseCase {

    #region Constructors and parsers

    protected ObligationsUseCases() {
      // no-op
    }

    static public ObligationsUseCases UseCaseInteractor() {
      return ObligationsUseCases.CreateInstance<ObligationsUseCases>();
    }

    #endregion Constructors and parsers

    #region Use cases

    public ObligationDto GetObligation(string obligationUID) {
      Assertion.AssertObject(obligationUID, "obligationUID");

      var obligation = Obligation.Parse(obligationUID);

      return ObligationMapper.Map(obligation);
    }


    public FixedList<ObligationDescriptorDto> SearchObligations(SearchObligationsCommand searchCommand) {
      Assertion.AssertObject(searchCommand, "searchCommand");

      FixedList<Obligation> obligations = ObligationsDataService.SearchObligations(searchCommand);

      return ObligationMapper.Map(obligations);
    }

    #endregion Use cases

  }  // class ObligationsUseCases

}  // namespace Empiria.Compliance.UseCases
