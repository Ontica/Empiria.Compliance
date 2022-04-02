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

namespace Empiria.Compliance.Adapters {

  /// <summary>Command payload used to search regulatory compliance obligations.</summary>
  public class SearchObligationsCommand {

    public string Keywords {
      get; set;
    } = string.Empty;


    public string OrderBy {
      get; set;
    } = "Name";


    public int PageSize {
      get; set;
    } = 500;


    public int Page {
      get; set;
    } = 1;

  }  // class SearchObligationsCommand

}  // namespace Empiria.Compliance.Adapters
