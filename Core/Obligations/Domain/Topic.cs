/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Domain Layer                            *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Information holder                      *
*  Type     : Topic                                      License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Describes a topic.                                                                             *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Compliance {

  /// <summary>Describes a topic.</summary>
  internal class Topic {

    #region Constructors and parsers

    protected Topic(string topic) {

    }

    static public FixedList<string> List {
      get {
        var list = GeneralList.Parse("Obligations.Topics.List");

        FixedList<string> items = list.GetItems<string>();

        items.Sort((x, y) => x.CompareTo(y));

        return items;
      }
    }

    #endregion Constructors and parsers

  }  // class Topic

}  // namespace Empiria.Compliance
