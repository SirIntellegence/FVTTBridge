
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class BaseEntitySheet{
       public dynamic entity(){return null;}//dummy return
       public dynamic isEditable(){return null;}//dummy return
       public dynamic defaultOptions(){return null;}//dummy return
       public dynamic title(){return null;}//dummy return
       public dynamic getData(){return null;}//dummy return
       public dynamic _getHeaderButtons(){return null;}//dummy return
       public dynamic _updateObject(dynamic evt, dynamic formData){return null;}//dummy return

    }
        
}