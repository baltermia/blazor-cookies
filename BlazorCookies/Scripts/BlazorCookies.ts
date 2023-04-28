namespace BlazorCookies.Scripts {
    /**
     * Interface representing a DotNetObjekt
     */
    interface DotNetObjectReference {
        /**
         * Invokes the method specified with the identifier on the dotnet object with the given arguments
         * @param identifier The identifier of the JSInvokable method in the dotnet object
         * @param args The arguments that are given when invoking the method
         */
        invokeMethodAsync(identifier: string, ...args: any): any;
    }

    export class BlazorCookiesInterop {
        
    }
}