/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Use cases Layer                         *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Use case interactor class               *
*  Type     : RegulatorsUseCases                         License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Use cases for compliance regulator entities.                                                   *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Services;

namespace Empiria.Compliance.UseCases {

  /// <summary>Use cases for compliance regulator entities.</summary>
  public class RegulatorsUseCases : UseCase {

    #region Constructors and parsers

    protected RegulatorsUseCases() {
      // no-op
    }

    static public RegulatorsUseCases UseCaseInteractor() {
      return UseCase.CreateInstance<RegulatorsUseCases>();
    }

    #endregion Constructors and parsers

    #region Use cases

    public FixedList<NamedEntityDto> GetRegulators() {

      FixedList<Regulator> regulators = Regulator.GetList();

      return regulators.MapToNamedEntityList();
    }

    #endregion Use cases

  }  // class RegulatorsUseCases

}  // namespace Empiria.Compliance.UseCases
