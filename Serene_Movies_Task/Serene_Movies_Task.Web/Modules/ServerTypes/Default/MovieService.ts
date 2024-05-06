import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { MovieRow } from "./MovieRow";

export namespace MovieService {
    export const baseUrl = 'Default/Movie';

    export declare function Create(request: SaveRequest<MovieRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<MovieRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MovieRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<MovieRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<MovieRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<MovieRow>>;

    export const Methods = {
        Create: "Default/Movie/Create",
        Update: "Default/Movie/Update",
        Delete: "Default/Movie/Delete",
        Retrieve: "Default/Movie/Retrieve",
        List: "Default/Movie/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>MovieService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}