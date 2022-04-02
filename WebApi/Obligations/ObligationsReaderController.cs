/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                       Component : Web Api                               *
*  Assembly : Empiria.Compliance.WebApi.dll                Pattern   : Controller                            *
*  Type     : ObligationsReaderController                  License   : Please read LICENSE.txt file          *
*                                                                                                            *
*  Summary  : Web Api used to read regulatory compliance obligations.                                        *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System.Web.Http;

using Empiria.WebApi;

using Empiria.Compliance.UseCases;
using Empiria.Compliance.Adapters;

namespace Empiria.Compliance.Obligations.WebApi {

  /// <summary>Web Api used to read regulatory compliance obligations.</summary>
  public class ObligationsReaderController : WebApiController {

    #region Web Apis

    [HttpGet]
    [Route("v3/compliance/obligations/{obligationUID:guid}")]
    public SingleObjectModel GetObligation([FromUri] string obligationUID) {

      using (var usecases = ObligationsUseCases.UseCaseInteractor()) {
        ObligationDto obligation = usecases.GetObligation(obligationUID);

        return new SingleObjectModel(this.Request, obligation);
      }
    }


    [HttpPost]
    [Route("v3/compliance/obligations")]
    public CollectionModel SearchObligations([FromBody] SearchObligationsCommand searchCommand) {

      base.RequireBody(searchCommand);

      using (var usecases = ObligationsUseCases.UseCaseInteractor()) {
        FixedList<ObligationDescriptorDto> obligations = usecases.SearchObligations(searchCommand);

        return new CollectionModel(this.Request, obligations);
      }
    }

    #endregion Web Apis

  }  // class ObligationsReaderController

}  //namespace Empiria.Compliance.Obligations.WebApi
