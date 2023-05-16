/*
' Copyright (c) 2023 Daff
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace Daff.Modules.Dnn.D.Proba_3_cart.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Dnn.D.Proba_3_cart
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Dnn.D.Proba_3_cartInfo> colDnn.D.Proba_3_carts = GetDnn.D.Proba_3_carts(ModuleID);
        //if (colDnn.D.Proba_3_carts.Count != 0)
        //{
        //    strXML += "<Dnn.D.Proba_3_carts>";

        //    foreach (Dnn.D.Proba_3_cartInfo objDnn.D.Proba_3_cart in colDnn.D.Proba_3_carts)
        //    {
        //        strXML += "<Dnn.D.Proba_3_cart>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDnn.D.Proba_3_cart.Content) + "</content>";
        //        strXML += "</Dnn.D.Proba_3_cart>";
        //    }
        //    strXML += "</Dnn.D.Proba_3_carts>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDnn.D.Proba_3_carts = DotNetNuke.Common.Globals.GetContent(Content, "Dnn.D.Proba_3_carts");
        //foreach (XmlNode xmlDnn.D.Proba_3_cart in xmlDnn.D.Proba_3_carts.SelectNodes("Dnn.D.Proba_3_cart"))
        //{
        //    Dnn.D.Proba_3_cartInfo objDnn.D.Proba_3_cart = new Dnn.D.Proba_3_cartInfo();
        //    objDnn.D.Proba_3_cart.ModuleId = ModuleID;
        //    objDnn.D.Proba_3_cart.Content = xmlDnn.D.Proba_3_cart.SelectSingleNode("content").InnerText;
        //    objDnn.D.Proba_3_cart.CreatedByUser = UserID;
        //    AddDnn.D.Proba_3_cart(objDnn.D.Proba_3_cart);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Dnn.D.Proba_3_cartInfo> colDnn.D.Proba_3_carts = GetDnn.D.Proba_3_carts(ModInfo.ModuleID);

        //foreach (Dnn.D.Proba_3_cartInfo objDnn.D.Proba_3_cart in colDnn.D.Proba_3_carts)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDnn.D.Proba_3_cart.Content, objDnn.D.Proba_3_cart.CreatedByUser, objDnn.D.Proba_3_cart.CreatedDate, ModInfo.ModuleID, objDnn.D.Proba_3_cart.ItemId.ToString(), objDnn.D.Proba_3_cart.Content, "ItemId=" + objDnn.D.Proba_3_cart.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
