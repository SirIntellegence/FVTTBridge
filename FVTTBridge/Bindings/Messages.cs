
using Bridge;
using System;
        
        
namespace FVTTBridge.Bindings
{
        
    [External]
    [Namespace(false)]    
    public class Messages{
       [Name("object")]
       public dynamic jsobject(){return null;}//dummy return
       public dynamic render(dynamic force){return null;}//dummy return
       public dynamic sayBubble(dynamic message){return null;}//dummy return
       public dynamic export(){return null;}//dummy return
       public dynamic flush(){return null;}//dummy return

    }
        
}