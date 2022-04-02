/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                       Component : Web Api                               *
*  Assembly : Empiria.Compliance.WebApi.dll                Pattern   : Controller                            *
*  Type     : TopicsController                             License   : Please read LICENSE.txt file          *
*                                                                                                            *
*  Summary  : Web Api used to read and write obligation's topics.                                            *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System.Web.Http;

using Empiria.WebApi;

using Empiria.Compliance.UseCases;

namespace Empiria.Compliance.Obligations.WebApi {

  /// <summary>Web Api used to read and write obligation's topics.</summary>
  public class TopicsController : WebApiController {

    #region Web Apis

    [HttpGet]
    [Route("v3/compliance/topics")]
    public CollectionModel GetTopics() {
      using (var usecases = TopicsUseCases.UseCaseInteractor()) {
        FixedList<string> topics = usecases.GetTopics();

        return new CollectionModel(this.Request, topics);
      }
    }

    #endregion Web Apis

  }  // class TopicsController

}  //namespace Empiria.Compliance.Obligations.WebApi
