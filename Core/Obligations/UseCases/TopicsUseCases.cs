/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Use cases Layer                         *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Use case interactor class               *
*  Type     : TopicsUseCases                             License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Use cases for topics.                                                                          *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Services;

namespace Empiria.Compliance.UseCases {

  /// <summary>Use cases for topics.</summary>
  public class TopicsUseCases : UseCase {

    #region Constructors and parsers

    protected TopicsUseCases() {
      // no-op
    }

    static public TopicsUseCases UseCaseInteractor() {
      return UseCase.CreateInstance<TopicsUseCases>();
    }

    #endregion Constructors and parsers

    #region Use cases

    public FixedList<string> GetTopics() {
      return Topic.List;
    }

    #endregion Use cases

  }  // class TopicsUseCases

}  // namespace Empiria.Compliance.UseCases
