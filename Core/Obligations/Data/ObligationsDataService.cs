/* Empiria Steps *********************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Data Access Layer                       *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Data Services                           *
*  Type     : ObligationsDataService                     License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Data read and write services for regulatory compliance obligations.                            *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Data;

namespace Empiria.Compliance.Data {

  /// <summary>Data read and write services for regulatory compliance obligations.</summary>
  static internal class ObligationsDataService {

    static internal FixedList<Obligation> SearchObligations(string filter, string orderBy) {
      var sql = $"SELECT * FROM EOPObligations " +
                $"WHERE {filter} " +
                $"ORDER BY {orderBy}";

      var op = DataOperation.Parse(sql);

      return DataReader.GetFixedList<Obligation>(op);
    }

  }  // class ObligationsDataService

}  // namespace Empiria.Compliance.Data
