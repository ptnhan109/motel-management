export function getToken(){
    let token = localStorage.getItem("imoma.token");
    if(token == null){
        return '';
    }
    return localStorage.getItem("imoma.token");
}

export function setToken(token){
    localStorage.setItem("imoma.token",token);
}