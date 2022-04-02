/* Empiria Compliance ****************************************************************************************
*                                                                                                            *
*  Module   : Obligations Management                       Component : Web Api                               *
*  Assembly : Empiria.Compliance.WebApi.dll                Pattern   : Controller                            *
*  Type     : ProceduresController                         License   : Please read LICENSE.txt file          *
*                                                                                                            *
*  Summary  : Web api used to read and write regulatory compliance procedures.                               *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System.Web.Http;

using Empiria.WebApi;

using Empiria.Compliance.UseCases;
using Empiria.Compliance.Adapters;

namespace Empiria.Compliance.Obligations.WebApi {

  /// <summary>Web api used to read and write regulatory compliance procedures.</summary>
  public class ProceduresController : WebApiController {

    #region Web Apis

    [HttpGet]
    [Route("v3/compliance/procedures")]
    public CollectionModel GetProcedures() {
      using (var usecases = ProceduresUseCases.UseCaseInteractor()) {
        FixedList<ProcedureDescriptorDto> procedures = usecases.GetProcedures();

        return new CollectionModel(this.Request, procedures);
      }
    }

    #endregion Web Apis

  }  // class ProceduresController

}  //namespace Empiria.Compliance.Obligations.WebApi
