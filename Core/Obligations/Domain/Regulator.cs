/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Domain Layer                            *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Empiria Object                          *
*  Type     : Regulator                                  License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Describes a compliance regulator entity.                                                       *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Contacts;

namespace Empiria.Compliance {

  /// <summary>Describes a compliance regulator entity.</summary>
  public class Regulator : Organization {

    #region Constructors and parsers

    protected Regulator() {
      // Required by Empiria Framework.
    }

    static public new Regulator Parse(string uid) {
      return BaseObject.ParseKey<Regulator>(uid);
    }


    static internal Regulator ParseNickName(string nickname) {
      var regultor = BaseObject.TryParse<Regulator>($"Nickname = '{nickname}'");

      Assertion.AssertObject(regultor, $"There is not defined a regulator with nickname '{nickname}'.");

      return regultor;
    }


    static public FixedList<Regulator> GetList() {
      var list = BaseObject.GetList<Regulator>(string.Empty, "Nickname");

      return list.ToFixedList();
    }


    static public new Regulator Empty => BaseObject.ParseEmpty<Regulator>();


    #endregion Constructors and parsers

  }  // class Regulator

}  // namespace Empiria.Compliance
