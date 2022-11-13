import { LOCALSTORAGE } from "../contants/Storage";

export function getToken() {
    let token = localStorage.getItem(LOCALSTORAGE.TOKEN);
    if (token == null) {
        return '';
    }
    return localStorage.getItem(LOCALSTORAGE.TOKEN);
}

export function setToken(token) {
    localStorage.setItem(LOCALSTORAGE.TOKEN, token);
}