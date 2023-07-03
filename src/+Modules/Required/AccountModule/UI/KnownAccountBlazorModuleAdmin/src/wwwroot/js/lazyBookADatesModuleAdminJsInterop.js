// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function showPrompt(message) {
    return prompt(message, 'Type anything here');
  }
export function importCss() {
  var link = document.createElement("link");
  link.href = "/AccountModule-Module.css";
  link.type = "text/css";
  link.rel = "stylesheet";
  link.media = "screen,print";
  document.getElementsByTagNam("head")[0].appendChild( link );

  link = document.createElement("script");
  link.src = "/js/AccountModule3DCode.js";
  link.type = "javascript";
  document.getElementsByTagNam("head")[0].appendChild( link );

  link = document.createElement("script");
  link.src = "/js/AccountModuleCanvasCode.js";
  link.type = "javascript";
  document.getElementsByTagNam("head")[0].appendChild( link );

  link = document.createElement("script");
  link.src = "/js/AccountModuleSideKick.js";
  link.type = "javascript";
  document.getElementsByTagNam("head")[0].appendChild( link );
}

  