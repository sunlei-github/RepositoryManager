import Vue from "vue";
import axios from "axios";

const apiAxios = axios.create({
    baseURL: 'http://localhost:21021/api/services/app/', //api的请求基地址
    withCredentials: true, //设置跨域
    headers: {},

});

function axiosget(url, params, response) {
    return apiAxios('GET', url, params, response)
}

function axiospost(url, params, response) {
    return apiAxios('POST', url, params, response)
}

function axiosput(url, params, response) {
    return apiAxios('POST', url, params, response)
}

function axiosdelete(url, params, response) {
    return apiAxios('DELETE', url, params, response)
}



Vue.prototype.$axios = {
    axiosget,
    axiospost,
    axiosput,
    axiosdelete
}