(function(){for(var aa="function"==typeof Object.defineProperties?Object.defineProperty:function(a,b,c){if(c.get||c.set)throw new TypeError("ES3 does not support getters and setters.");a!=Array.prototype&&a!=Object.prototype&&(a[b]=c.value)},k="undefined"!=typeof window&&window===this?this:"undefined"!=typeof global&&null!=global?global:this,l=["Reflect",
"apply"],n=0;n<l.length-1;n++){var p=l[n];p in k||(k[p]={});k=k[p]}var ba=l[l.length-1],ca=k[ba],da=function(){if(ca)return ca;var a=Function.prototype.apply;return function(b,c,d){return a.call(b,c,d)}}();
da!=ca&&null!=da&&aa(k,ba,{configurable:!0,writable:!0,value:da});var q=this;function ea(a){a=a.split(".");for(var b=q,c;c=a.shift();)if(null!=b[c])b=b[c];else return null;return b}
function ga(a){var b=typeof a;if("object"==b)if(a){if(a instanceof Array)return"array";if(a instanceof Object)return b;var c=Object.prototype.toString.call(a);if("[object Window]"==c)return"object";if("[object Array]"==c||"number"==typeof a.length&&"undefined"!=typeof a.splice&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("splice"))return"array";if("[object Function]"==c||"undefined"!=typeof a.call&&"undefined"!=typeof a.propertyIsEnumerable&&!a.propertyIsEnumerable("call"))return"function"}else return"null";
else if("function"==b&&"undefined"==typeof a.call)return"object";return b}
function t(a){return"string"==typeof a}
var ha=Date.now||function(){return+new Date};/*
 gapi.loader.OBJECT_CREATE_TEST_OVERRIDE &&*/
var u=window,x=document,ia=u.location;function ja(){}
var ka=/\[native code\]/;function y(a,b,c){return a[b]=a[b]||c}
function la(a){for(var b=0;b<this.length;b++)if(this[b]===a)return b;return-1}
function ma(a){a=a.sort();for(var b=[],c=void 0,d=0;d<a.length;d++){var e=a[d];e!=c&&b.push(e);c=e}return b}
function z(){var a;if((a=Object.create)&&ka.test(a))a=a(null);else{a={};for(var b in a)a[b]=void 0}return a}
var A=y(u,"gapi",{});var B;B=y(u,"___jsl",z());y(B,"I",0);y(B,"hel",10);function na(){var a=ia.href;if(B.dpo)var b=B.h;else{b=B.h;var c=RegExp("([#].*&|[#])jsh=([^&#]*)","g"),d=RegExp("([?#].*&|[?#])jsh=([^&#]*)","g");if(a=a&&(c.exec(a)||d.exec(a)))try{b=decodeURIComponent(a[2])}catch(e){}}return b}
function oa(a){var b=y(B,"PQ",[]);B.PQ=[];var c=b.length;if(0===c)a();else for(var d=0,e=function(){++d===c&&a()},f=0;f<c;f++)b[f](e)}
function pa(a){return y(y(B,"H",z()),a,z())}
;var F=y(B,"perf",z());y(F,"g",z());var qa=y(F,"i",z());y(F,"r",[]);z();z();function G(a,b,c){b&&0<b.length&&(b=ra(b),c&&0<c.length&&(b+="___"+ra(c)),28<b.length&&(b=b.substr(0,28)+(b.length-28)),c=b,b=y(qa,"_p",z()),y(b,c,z())[a]=(new Date).getTime(),b=F.r,"function"===typeof b?b(a,"_p",c):b.push([a,"_p",c]))}
function ra(a){return a.join("__").replace(/\./g,"_").replace(/\-/g,"_").replace(/\,/g,"_")}
;var sa=z(),H=[];function I(a){throw Error("Bad hint"+(a?": "+a:""));}
H.push(["jsl",function(a){for(var b in a)if(Object.prototype.hasOwnProperty.call(a,b)){var c=a[b];"object"==typeof c?B[b]=y(B,b,[]).concat(c):y(B,b,c)}if(b=a.u)a=y(B,"us",[]),a.push(b),(b=/^https:(.*)$/.exec(b))&&a.push("http:"+b[1])}]);
var ta=/^(\/[a-zA-Z0-9_\-]+)+$/,ua=[/\/amp\//,/\/amp$/,/^\/amp$/],va=/^[a-zA-Z0-9\-_\.,!]+$/,wa=/^gapi\.loaded_[0-9]+$/,xa=/^[a-zA-Z0-9,._-]+$/;function ya(a,b,c,d){var e=a.split(";"),f=e.shift(),g=sa[f],h=null;g?h=g(e,b,c,d):I("no hint processor for: "+f);h||I("failed to generate load url");b=h;c=b.match(za);(d=b.match(Aa))&&1===d.length&&Ba.test(b)&&c&&1===c.length||I("failed sanity: "+a);return h}
function Ca(a,b,c,d){function e(a){return encodeURIComponent(a).replace(/%2C/g,",")}
a=Da(a);wa.test(c)||I("invalid_callback");b=Ea(b);d=d&&d.length?Ea(d):null;return[encodeURIComponent(a.g).replace(/%2C/g,",").replace(/%2F/g,"/"),"/k=",e(a.version),"/m=",e(b),d?"/exm="+e(d):"","/rt=j/sv=1/d=1/ed=1",a.a?"/am="+e(a.a):"",a.c?"/rs="+e(a.c):"",a.f?"/t="+e(a.f):"","/cb=",e(c)].join("")}
function Da(a){"/"!==a.charAt(0)&&I("relative path");for(var b=a.substring(1).split("/"),c=[];b.length;){a=b.shift();if(!a.length||0==a.indexOf("."))I("empty/relative directory");else if(0<a.indexOf("=")){b.unshift(a);break}c.push(a)}a={};for(var d=0,e=b.length;d<e;++d){var f=b[d].split("="),g=decodeURIComponent(f[0]),h=decodeURIComponent(f[1]);2==f.length&&g&&h&&(a[g]=a[g]||h)}b="/"+c.join("/");ta.test(b)||I("invalid_prefix");c=0;for(d=ua.length;c<d;++c)ua[c].test(b)&&I("invalid_prefix");c=J(a,"k",
!0);d=J(a,"am");e=J(a,"rs");a=J(a,"t");return{g:b,version:c,a:d,c:e,f:a}}
function Ea(a){for(var b=[],c=0,d=a.length;c<d;++c){var e=a[c].replace(/\./g,"_").replace(/-/g,"_");xa.test(e)&&b.push(e)}return b.join(",")}
function J(a,b,c){a=a[b];!a&&c&&I("missing: "+b);if(a){if(va.test(a))return a;I("invalid: "+b)}return null}
var Ba=/^https?:\/\/[a-z0-9_.-]+\.google\.com(:\d+)?\/[a-zA-Z0-9_.,!=\-\/]+$/,Aa=/\/cb=/g,za=/\/\//g;function Fa(){var a=na();if(!a)throw Error("Bad hint");return a}
sa.m=function(a,b,c,d){(a=a[0])||I("missing_hint");return"https://apis.google.com"+Ca(a,b,c,d)};
var L=decodeURI("%73cript"),Ga=/^[-+_0-9\/A-Za-z]+={0,2}$/;function Ha(a,b){for(var c=[],d=0;d<a.length;++d){var e=a[d];e&&0>la.call(b,e)&&c.push(e)}return c}
function Ia(){var a=B.nonce;if(void 0!==a)return a&&a===String(a)&&a.match(Ga)?a:B.nonce=null;var b=y(B,"us",[]);if(!b||!b.length)return B.nonce=null;for(var c=x.getElementsByTagName(L),d=0,e=c.length;d<e;++d){var f=c[d];if(f.src&&(a=String(f.nonce||f.getAttribute("nonce")||"")||null)){for(var g=0,h=b.length;g<h&&b[g]!==f.src;++g);if(g!==h&&a&&a===String(a)&&a.match(Ga))return B.nonce=a}}return null}
function Ja(a){if("loading"!=x.readyState)Ka(a);else{var b=Ia(),c="";null!==b&&(c=' nonce="'+b+'"');x.write("<"+L+' src="'+encodeURI(a)+'"'+c+"></"+L+">")}}
function Ka(a){var b=x.createElement(L);b.setAttribute("src",a);a=Ia();null!==a&&b.setAttribute("nonce",a);b.async="true";(a=x.getElementsByTagName(L)[0])?a.parentNode.insertBefore(b,a):(x.head||x.body||x.documentElement).appendChild(b)}
function La(a,b){var c=b&&b._c;if(c)for(var d=0;d<H.length;d++){var e=H[d][0],f=H[d][1];f&&Object.prototype.hasOwnProperty.call(c,e)&&f(c[e],a,b)}}
function Ma(a,b,c){Na(function(){var c=b===na()?y(A,"_",z()):z();c=y(pa(b),"_",c);a(c)},c)}
function Oa(a,b){var c=b||{};"function"==typeof b&&(c={},c.callback=b);La(a,c);var d=a?a.split(":"):[],e=c.h||Fa(),f=y(B,"ah",z());if(f["::"]&&d.length){for(var g=[],h=null;h=d.shift();){var m=h.split("."),m=f[h]||f[m[1]&&"ns:"+m[0]||""]||e,C=g.length&&g[g.length-1]||null,D=C;C&&C.hint==m||(D={hint:m,b:[]},g.push(D));D.b.push(h)}var K=g.length;if(1<K){var E=c.callback;E&&(c.callback=function(){0==--K&&E()})}for(;d=g.shift();)Pa(d.b,c,d.hint)}else Pa(d||[],c,e)}
function Pa(a,b,c){function d(a,b){if(K)return 0;u.clearTimeout(D);E.push.apply(E,r);var d=((A||{}).config||{}).update;d?d(f):f&&y(B,"cu",[]).push(f);if(b){G("me0",a,T);try{Ma(b,c,C)}finally{G("me1",a,T)}}return 1}
a=ma(a)||[];var e=b.callback,f=b.config,g=b.timeout,h=b.ontimeout,m=b.onerror,C=void 0;"function"==typeof m&&(C=m);var D=null,K=!1;if(g&&!h||!g&&h)throw"Timeout requires both the timeout parameter and ontimeout parameter to be set";var m=y(pa(c),"r",[]).sort(),E=y(pa(c),"L",[]).sort(),T=[].concat(m);0<g&&(D=u.setTimeout(function(){K=!0;h()},g));
var r=Ha(a,E);if(r.length){var r=Ha(a,m),v=y(B,"CP",[]),w=v.length;v[w]=function(a){function b(){var a=v[w+1];a&&a()}
function c(b){v[w]=null;d(r,a)&&oa(function(){e&&e();b()})}
if(!a)return 0;G("ml1",r,T);0<w&&v[w-1]?v[w]=function(){c(b)}:c(b)};
if(r.length){var fa="loaded_"+B.I++;A[fa]=function(a){v[w](a);A[fa]=null};
a=ya(c,r,"gapi."+fa,m);m.push.apply(m,r);G("ml0",r,T);b.sync||u.___gapisync?Ja(a):Ka(a)}else v[w](ja)}else d(r)&&e&&e()}
function Na(a,b){if(B.hee&&0<B.hel)try{return a()}catch(c){b&&b(c),B.hel--,Oa("debug_error",function(){try{window.___jsl.hefn(c)}catch(d){throw c;}})}else try{return a()}catch(c){throw b&&b(c),c;
}}
A.load=function(a,b){return Na(function(){return Oa(a,b)})};var Qa=String.prototype.trim?function(a){return a.trim()}:function(a){return a.replace(/^[\s\xa0]+|[\s\xa0]+$/g,"")};
function Ra(a,b){return a<b?-1:a>b?1:0}
;var Sa=Array.prototype.indexOf?function(a,b,c){return Array.prototype.indexOf.call(a,b,c)}:function(a,b,c){c=null==c?0:0>c?Math.max(0,a.length+c):c;
if(t(a))return t(b)&&1==b.length?a.indexOf(b,c):-1;for(;c<a.length;c++)if(c in a&&a[c]===b)return c;return-1},Ta=Array.prototype.filter?function(a,b,c){return Array.prototype.filter.call(a,b,c)}:function(a,b,c){for(var d=a.length,e=[],f=0,g=t(a)?a.split(""):a,h=0;h<d;h++)if(h in g){var m=g[h];
b.call(c,m,h,a)&&(e[f++]=m)}return e};
function Ua(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c],e=ga(d);if("array"==e||"object"==e&&"number"==typeof d.length){var e=a.length||0,f=d.length||0;a.length=e+f;for(var g=0;g<f;g++)a[e+g]=d[g]}else a.push(d)}}
;var M;a:{var Va=q.navigator;if(Va){var Wa=Va.userAgent;if(Wa){M=Wa;break a}}M=""};var Xa="constructor hasOwnProperty isPrototypeOf propertyIsEnumerable toLocaleString toString valueOf".split(" ");function Ya(a,b){for(var c,d,e=1;e<arguments.length;e++){d=arguments[e];for(c in d)a[c]=d[c];for(var f=0;f<Xa.length;f++)c=Xa[f],Object.prototype.hasOwnProperty.call(d,c)&&(a[c]=d[c])}}
;function Za(a,b){var c=$a;Object.prototype.hasOwnProperty.call(c,a)||(c[a]=b(a))}
;var ab=-1!=M.indexOf("Opera"),N=-1!=M.indexOf("Trident")||-1!=M.indexOf("MSIE"),bb=-1!=M.indexOf("Edge"),cb=-1!=M.indexOf("Gecko")&&!(-1!=M.toLowerCase().indexOf("webkit")&&-1==M.indexOf("Edge"))&&!(-1!=M.indexOf("Trident")||-1!=M.indexOf("MSIE"))&&-1==M.indexOf("Edge"),db=-1!=M.toLowerCase().indexOf("webkit")&&-1==M.indexOf("Edge");function eb(){var a=q.document;return a?a.documentMode:void 0}
var fb;a:{var gb="",hb=function(){var a=M;if(cb)return/rv\:([^\);]+)(\)|;)/.exec(a);if(bb)return/Edge\/([\d\.]+)/.exec(a);if(N)return/\b(?:MSIE|rv)[: ]([^\);]+)(\)|;)/.exec(a);if(db)return/WebKit\/(\S+)/.exec(a);if(ab)return/(?:Version)[ \/]?(\S+)/.exec(a)}();
hb&&(gb=hb?hb[1]:"");if(N){var ib=eb();if(null!=ib&&ib>parseFloat(gb)){fb=String(ib);break a}}fb=gb}var jb=fb,$a={};
function kb(a){Za(a,function(){for(var b=0,c=Qa(String(jb)).split("."),d=Qa(String(a)).split("."),e=Math.max(c.length,d.length),f=0;0==b&&f<e;f++){var g=c[f]||"",h=d[f]||"";do{g=/(\d*)(\D*)(.*)/.exec(g)||["","","",""];h=/(\d*)(\D*)(.*)/.exec(h)||["","","",""];if(0==g[0].length&&0==h[0].length)break;b=Ra(0==g[1].length?0:parseInt(g[1],10),0==h[1].length?0:parseInt(h[1],10))||Ra(0==g[2].length,0==h[2].length)||Ra(g[2],h[2]);g=g[3];h=h[3]}while(0==b)}return 0<=b})}
var lb;var mb=q.document;lb=mb&&N?eb()||("CSS1Compat"==mb.compatMode?parseInt(jb,10):5):void 0;var nb;if(!(nb=!cb&&!N)){var ob;if(ob=N)ob=9<=Number(lb);nb=ob}nb||cb&&kb("1.9.1");N&&kb("9");function pb(a){if(a.classList)return a.classList;a=a.className;return t(a)&&a.match(/\S+/g)||[]}
function qb(a,b){if(a.classList)var c=a.classList.contains(b);else c=pb(a),c=0<=Sa(c,b);return c}
function rb(a,b){a.classList?a.classList.add(b):qb(a,b)||(a.className+=0<a.className.length?" "+b:b)}
function sb(a,b){a.classList?a.classList.remove(b):qb(a,b)&&(a.className=Ta(pb(a),function(a){return a!=b}).join(" "))}
;function O(a,b){this.width=a;this.height=b}
O.prototype.ceil=function(){this.width=Math.ceil(this.width);this.height=Math.ceil(this.height);return this};
O.prototype.floor=function(){this.width=Math.floor(this.width);this.height=Math.floor(this.height);return this};
O.prototype.round=function(){this.width=Math.round(this.width);this.height=Math.round(this.height);return this};function tb(){var a=document;return t("yt-subscribe-card")?a.getElementById("yt-subscribe-card"):"yt-subscribe-card"}
;function ub(a){var b=a.offsetWidth,c=a.offsetHeight,d=db&&!b&&!c;if((void 0===b||d)&&a.getBoundingClientRect){a:{try{var e=a.getBoundingClientRect()}catch(f){e={left:0,top:0,right:0,bottom:0};break a}N&&a.ownerDocument.body&&(a=a.ownerDocument,e.left-=a.documentElement.clientLeft+a.body.clientLeft,e.top-=a.documentElement.clientTop+a.body.clientTop)}return new O(e.right-e.left,e.bottom-e.top)}return new O(b,c)}
;var P=window.yt&&window.yt.config_||window.ytcfg&&window.ytcfg.data_||{},Q=["yt","config_"],R=q;Q[0]in R||!R.execScript||R.execScript("var "+Q[0]);for(var S;Q.length&&(S=Q.shift());)Q.length||void 0===P?R[S]&&R[S]!==Object.prototype[S]?R=R[S]:R=R[S]={}:R[S]=P;function vb(){return ea("gapi.iframes.getContext")()}
function wb(){return ea("gapi.iframes.SAME_ORIGIN_IFRAMES_FILTER")}
;ha();function xb(a){try{var b=yb,c=wb();a.register("msg-hovercard-subscription",b,c)}catch(d){}}
function yb(a){if(a){a=!!a.isSubscribed;var b=tb();a?sb(b,"subscribe"):rb(b,"subscribe");a?rb(b,"subscribed"):sb(b,"subscribed")}}
;var U;
function zb(){var a=tb();b:{var b=9==a.nodeType?a:a.ownerDocument||a.document;if(b.defaultView&&b.defaultView.getComputedStyle&&(b=b.defaultView.getComputedStyle(a,null))){b=b.display||b.getPropertyValue("display")||"";break b}b=""}if("none"!=(b||(a.currentStyle?a.currentStyle.display:null)||a.style&&a.style.display))a=ub(a);else{b=a.style;var c=b.display,d=b.visibility,e=b.position;b.visibility="hidden";b.position="absolute";b.display="inline";a=ub(a);b.display=c;b.position=e;b.visibility=d}a={width:a.width,
height:a.height};vb().ready(a,null,void 0);a=wb();vb().addOnOpenerHandler(xb,null,a)}
U="function"==ga(zb)?{callback:zb}:zb||{};
if(U.gapiHintOverride||"GAPI_HINT_OVERRIDE"in P&&P.GAPI_HINT_OVERRIDE){var Ab;var V=document.location.href;if(-1!=V.indexOf("?")){var V=(V||"").split("#")[0],Bb=V.split("?",2),W=1<Bb.length?Bb[1]:Bb[0];"?"==W.charAt(0)&&(W=W.substr(1));for(var Cb=W.split("&"),X={},Db=0,Eb=Cb.length;Db<Eb;Db++){var Y=Cb[Db].split("=");if(1==Y.length&&Y[0]||2==Y.length){var Z=decodeURIComponent((Y[0]||"").replace(/\+/g," ")),Fb=decodeURIComponent((Y[1]||"").replace(/\+/g," "));Z in X?"array"==ga(X[Z])?Ua(X[Z],Fb):X[Z]=
[X[Z],Fb]:X[Z]=Fb}}Ab=X}else Ab={};var Gb=Ab.gapi_jsh;Gb&&Ya(U,{_c:{jsl:{h:Gb}}})}Oa("gapi.iframes:gapi.iframes.style.common",U);}).call(this);
