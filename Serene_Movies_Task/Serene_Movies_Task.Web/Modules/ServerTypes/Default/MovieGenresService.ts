import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { MovieGenresRow } from "./MovieGenresRow";

export namespace MovieGenresService {
    export const baseUrl = 'Default/MovieGenres';

    export declare function Create(request: SaveRequest<MovieGenresRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<MovieGenresRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MovieGenresRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<MovieGenresRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<MovieGenresRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<MovieGenresRow>>;

    export const Methods = {
        Create: "Default/MovieGenres/Create",
        Update: "Default/MovieGenres/Update",
        Delete: "Default/MovieGenres/Delete",
        Retrieve: "Default/MovieGenres/Retrieve",
        List: "Default/MovieGenres/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>MovieGenresService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}