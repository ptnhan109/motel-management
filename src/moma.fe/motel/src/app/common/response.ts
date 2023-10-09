export class AppResponse<T>{
    messsage : string;
    httpCode : number;
    errorCode : string;
    isSucceeded : boolean;
    data: T;
}