/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                     Component : Interface adapters                      *
*  Assembly : Empiria.Compliance.Core.dll                Pattern   : Command payload                         *
*  Type     : SearchObligationsCommand                   License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Command payload used to search regulatory compliance obligations.                              *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;
using System.Linq;

namespace Empiria.Compliance.Adapters {

  /// <summary>Command payload used to search regulatory compliance obligations.</summary>
  public class SearchObligationsCommand {


    public string[] Regulators {
      get; set;
    } = new string[0];


    public string[] Topics {
      get; set;
    } = new string[0];


    public string Keywords {
      get; set;
    } = string.Empty;


    public string OrderBy {
      get; set;
    } = "Name";


  }  // class SearchObligationsCommand



  /// <summary>Extension methods for SearchObligationsCommand interface adapter.</summary>
  static internal class ObligationsSearchCommandExtension {

    #region Public methods

    static public string MapToFilterString(this SearchObligationsCommand command) {
      string keywordsFilter = BuildKeywordsFilter(command.Keywords);
      string regulatorsFilter = BuildRegulatorsFilter(command.Regulators);
      string topicsFilter = BuildTopicsFilter(command.Topics);

      var filter = new Filter(keywordsFilter);

      filter.AppendAnd(regulatorsFilter);
      filter.AppendAnd(topicsFilter);

      if (!filter.IsEmpty) {
        return filter.ToString();
      } else {
        return SearchExpression.AllRecordsFilter;
      }
    }

    #endregion Public methods

    #region Private methods

    static private string BuildKeywordsFilter(string keywords) {
      return SearchExpression.ParseAndLikeKeywords("Keywords", keywords);
    }


    static private string BuildRegulatorsFilter(string[] regulatorsUids) {
      if (regulatorsUids.Length == 0) {
        return string.Empty;
      }

      string[] idsArray = regulatorsUids.Select(uid => Regulator.Parse(uid).Id.ToString())
                                        .ToArray();

      return $"RegulatorId IN ({String.Join(", ", idsArray)})";
    }


    static private string BuildTopicsFilter(string[] topics) {
      if (topics.Length == 0) {
        return string.Empty;
      }

      string[] formattedTopics = topics.Select(x => $"'{x}'")
                                      .ToArray();

      return $"Topics IN ({String.Join(", ", formattedTopics)})";
    }

    #endregion Private methods

  }  // SearchObligationsCommand

}  // namespace Empiria.Compliance.Adapters
