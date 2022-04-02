/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Use cases Layer                         *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Use case interactor class               *
*  Type     : ProceduresUseCases                         License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Use cases for regulatory compliance procedures.                                                *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Services;

using Empiria.Compliance.Adapters;

namespace Empiria.Compliance.UseCases {

  /// <summary>Use cases for regulatory compliance procedures.</summary>
  public class ProceduresUseCases : UseCase {

    #region Constructors and parsers

    protected ProceduresUseCases() {
      // no-op
    }

    static public ProceduresUseCases UseCaseInteractor() {
      return UseCase.CreateInstance<ProceduresUseCases>();
    }

    #endregion Constructors and parsers

    #region Use cases

    public FixedList<ProcedureDescriptorDto> GetProcedures() {
      FixedList<Procedure> procedures = Procedure.GetList();

      return ProcedureMapper.Map(procedures);
    }

    #endregion Use cases

  }  // class ProceduresUseCases

}  // namespace Empiria.Compliance.UseCases
