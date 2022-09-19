export function getToken(){
    return localStorage.getItem("imoma.token");
}

export function setToken(token){
    localStorage.setItem("imoma.token",token);
}