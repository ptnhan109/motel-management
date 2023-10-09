import { Injectable } from '@angular/core';
import { LOCALSTORAGE } from '../contants/Storage';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  constructor() { }

  setToken(token){
    localStorage.setItem(LOCALSTORAGE.TOKEN,token);
  }

  setName(name){
    localStorage.setItem(LOCALSTORAGE.NAME,name);
  }

  removeToken(){
    localStorage.removeItem(LOCALSTORAGE.TOKEN);
  }

  getName(){
    localStorage.getItem(LOCALSTORAGE.NAME);
  }

  getToken(){
    return localStorage.getItem(LOCALSTORAGE.TOKEN);
  }
}
