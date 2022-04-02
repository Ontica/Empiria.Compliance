/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                       Component : Web Api                               *
*  Assembly : Empiria.Compliance.WebApi.dll                Pattern   : Controller                            *
*  Type     : RegulatorsController                         License   : Please read LICENSE.txt file          *
*                                                                                                            *
*  Summary  : Query web api used to read regulators.                                                         *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System.Web.Http;

using Empiria.WebApi;

using Empiria.Compliance.UseCases;

namespace Empiria.Compliance.Obligations.WebApi {

  /// <summary>Query web api used to read regulators.</summary>
  public class RegulatorsController : WebApiController {

    #region Web Apis

    [HttpGet]
    [Route("v3/compliance/regulators")]
    public CollectionModel GetRegulators() {
      using (var usecases = RegulatorsUseCases.UseCaseInteractor()) {
        FixedList<NamedEntityDto> regulators = usecases.GetRegulators();

        return new CollectionModel(this.Request, regulators);
      }
    }

    #endregion Web Apis

  }  // class RegulatorsController

}  //namespace Empiria.Compliance.Obligations.WebApi
