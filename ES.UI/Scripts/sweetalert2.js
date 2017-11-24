!function (e, t) { "object" == typeof exports && "undefined" != typeof module ? module.exports = t() : "function" == typeof define && define.amd ? define(t) : e.Sweetalert2 = t() }(this, function () { "use strict"; var e = function (e) { var t = {}; for (var n in e) t[e[n]] = "swal2-" + e[n]; return t }, t = e(["container", "in", "iosfix", "modal", "overlay", "fade", "show", "hide", "noanimation", "close", "title", "content", "spacer", "confirm", "cancel", "icon", "image", "input", "file", "range", "select", "radio", "checkbox", "textarea", "inputerror", "validationerror", "progresssteps", "activeprogressstep", "progresscircle", "progressline", "loading", "styled"]), n = e(["success", "warning", "info", "question", "error"]), o = { title: "", titleText: "", text: "", html: "", type: null, customClass: "", animation: !0, allowOutsideClick: !0, allowEscapeKey: !0, showConfirmButton: !0, showCancelButton: !1, preConfirm: null, confirmButtonText: "OK", confirmButtonColor: "#3085d6", confirmButtonClass: null, cancelButtonText: "Cancel", cancelButtonColor: "#aaa", cancelButtonClass: null, buttonsStyling: !0, reverseButtons: !1, focusCancel: !1, showCloseButton: !1, showLoaderOnConfirm: !1, imageUrl: null, imageWidth: null, imageHeight: null, imageClass: null, timer: null, width: 500, padding: 20, background: "#fff", input: null, inputPlaceholder: "", inputValue: "", inputOptions: {}, inputAutoTrim: !0, inputClass: null, inputAttributes: {}, inputValidator: null, progressSteps: [], currentProgressStep: null, progressStepsDistance: "40px", onOpen: null, onClose: null }, r = ('\n  <div class="' + t.modal + '" tabIndex="-1">\n    <ul class="' + t.progresssteps + '"></ul>\n    <div class="' + t.icon + " " + n.error + '">\n      <span class="x-mark"><span class="line left"></span><span class="line right"></span></span>\n    </div>\n    <div class="' + t.icon + " " + n.question + '">?</div>\n    <div class="' + t.icon + " " + n.warning + '"><span class="body pulse-warning-ins"></span><span class="dot pulse-warning-ins"></span></div>\n    <div class="' + t.icon + " " + n.info + '">i</div>\n    <div class="' + t.icon + " " + n.success + '">\n      <span class="line tip"></span> <span class="line long"></span>\n      <div class="placeholder"></div> <div class="fix"></div>\n    </div>\n    <img class="' + t.image + '">\n    <h2 class="' + t.title + '"></h2>\n    <div class="' + t.content + '"></div>\n    <input class="' + t.input + '">\n    <input type="file" class="' + t.file + '">\n    <div class="' + t.range + '">\n      <output></output>\n      <input type="range">\n    </div>\n    <select class="' + t.select + '"></select>\n    <div class="' + t.radio + '"></div>\n    <label for="' + t.checkbox + '" class="' + t.checkbox + '">\n      <input type="checkbox">\n    </label>\n    <textarea class="' + t.textarea + '"></textarea>\n    <div class="' + t.validationerror + '"></div>\n    <hr class="' + t.spacer + '">\n    <button type="button" class="' + t.confirm + '">OK</button>\n    <button type="button" class="' + t.cancel + '">Cancel</button>\n    <span class="' + t.close + '">&times;</span>\n  </div>\n').replace(/(^|\n)\s*/g, ""), i = void 0, a = document.getElementsByClassName(t.container); a.length ? i = a[0] : ((i = document.createElement("div")).className = t.container, i.innerHTML = r); var l = function (e, t) { (e = String(e).replace(/[^0-9a-f]/gi, "")).length < 6 && (e = e[0] + e[0] + e[1] + e[1] + e[2] + e[2]), t = t || 0; for (var n = "#", o = 0; o < 3; o++) { var r = parseInt(e.substr(2 * o, 2), 16); n += ("00" + (r = Math.round(Math.min(Math.max(0, r + r * t), 255)).toString(16))).substr(r.length) } return n }, s = { previousWindowKeyDown: null, previousActiveElement: null, previousBodyPadding: null }, c = function () { if ("undefined" != typeof document) { if (!document.getElementsByClassName(t.container).length) { document.body.appendChild(i); var e = d(), n = B(e, t.input), o = B(e, t.file), r = e.querySelector("." + t.range + " input"), a = e.querySelector("." + t.range + " output"), l = B(e, t.select), s = e.querySelector("." + t.checkbox + " input"), c = B(e, t.textarea); return n.oninput = function () { $.resetValidationError() }, n.onkeydown = function (e) { setTimeout(function () { 13 === e.keyCode && (e.stopPropagation(), $.clickConfirm()) }, 0) }, o.onchange = function () { $.resetValidationError() }, r.oninput = function () { $.resetValidationError(), a.value = r.value }, r.onchange = function () { $.resetValidationError(), r.previousSibling.value = r.value }, l.onchange = function () { $.resetValidationError() }, s.onchange = function () { $.resetValidationError() }, c.oninput = function () { $.resetValidationError() }, e } } else console.error("SweetAlert2 requires document to initialize") }, u = function (e) { return i.querySelector("." + e) }, d = function () { return document.body.querySelector("." + t.modal) || c() }, p = function () { return d().querySelectorAll("." + t.icon) }, f = function () { return u(t.title) }, m = function () { return u(t.content) }, v = function () { return u(t.image) }, h = function () { return u(t.spacer) }, y = function () { return u(t.progresssteps) }, g = function () { return u(t.validationerror) }, b = function () { return u(t.confirm) }, w = function () { return u(t.cancel) }, C = function () { return u(t.close) }, k = function (e) { var t = [b(), w()]; return e && t.reverse(), t.concat(Array.prototype.slice.call(d().querySelectorAll("button:not([class^=swal2-]), input:not([type=hidden]), textarea, select"))) }, S = function (e, t) { return !!e.classList && e.classList.contains(t) }, x = function (e) { if (e.focus(), "file" !== e.type) { var t = e.value; e.value = "", e.value = t } }, E = function (e, t) { e && t && t.split(/\s+/).filter(Boolean).forEach(function (t) { e.classList.add(t) }) }, A = function (e, t) { e && t && t.split(/\s+/).filter(Boolean).forEach(function (t) { e.classList.remove(t) }) }, B = function (e, t) { for (var n = 0; n < e.childNodes.length; n++) if (S(e.childNodes[n], t)) return e.childNodes[n] }, P = function (e, t) { t || (t = "block"), e.style.opacity = "", e.style.display = t }, L = function (e) { e.style.opacity = "", e.style.display = "none" }, q = function (e) { for (; e.firstChild;) e.removeChild(e.firstChild) }, T = function (e) { return e.offsetWidth || e.offsetHeight || e.getClientRects().length }, M = function (e, t) { e.style.removeProperty ? e.style.removeProperty(t) : e.style.removeAttribute(t) }, V = function (e) { if (!T(e)) return !1; if ("function" == typeof MouseEvent) { var t = new MouseEvent("click", { view: window, bubbles: !1, cancelable: !0 }); e.dispatchEvent(t) } else if (document.createEvent) { var n = document.createEvent("MouseEvents"); n.initEvent("click", !1, !1), e.dispatchEvent(n) } else document.createEventObject ? e.fireEvent("onclick") : "function" == typeof e.onclick && e.onclick() }, H = function () { var e = document.createElement("div"), t = { WebkitAnimation: "webkitAnimationEnd", OAnimation: "oAnimationEnd oanimationend", msAnimation: "MSAnimationEnd", animation: "animationend" }; for (var n in t) if (t.hasOwnProperty(n) && void 0 !== e.style[n]) return t[n]; return !1 }(), O = function () { var e = d(); window.onkeydown = s.previousWindowKeyDown, s.previousActiveElement && s.previousActiveElement.focus && s.previousActiveElement.focus(), clearTimeout(e.timeout) }, N = function () { var e = document.createElement("div"); e.style.width = "50px", e.style.height = "50px", e.style.overflow = "scroll", document.body.appendChild(e); var t = e.offsetWidth - e.clientWidth; return document.body.removeChild(e), t }, j = function (e, t) { var n = void 0; return function () { clearTimeout(n), n = setTimeout(function () { n = null, e() }, t) } }, I = "function" == typeof Symbol && "symbol" == typeof Symbol.iterator ? function (e) { return typeof e } : function (e) { return e && "function" == typeof Symbol && e.constructor === Symbol && e !== Symbol.prototype ? "symbol" : typeof e }, D = (function () { function e(e) { this.value = e } function t(t) { function n(r, i) { try { var a = t[r](i), l = a.value; l instanceof e ? Promise.resolve(l.value).then(function (e) { n("next", e) }, function (e) { n("throw", e) }) : o(a.done ? "return" : "normal", a.value) } catch (e) { o("throw", e) } } function o(e, t) { switch (e) { case "return": r.resolve({ value: t, done: !0 }); break; case "throw": r.reject(t); break; default: r.resolve({ value: t, done: !1 }) } (r = r.next) ? n(r.key, r.arg) : i = null } var r, i; this._invoke = function (e, t) { return new Promise(function (o, a) { var l = { key: e, arg: t, resolve: o, reject: a, next: null }; i ? i = i.next = l : (r = i = l, n(e, t)) }) }, "function" != typeof t.return && (this.return = void 0) } "function" == typeof Symbol && Symbol.asyncIterator && (t.prototype[Symbol.asyncIterator] = function () { return this }), t.prototype.next = function (e) { return this._invoke("next", e) }, t.prototype.throw = function (e) { return this._invoke("throw", e) }, t.prototype.return = function (e) { return this._invoke("return", e) } }(), Object.assign || function (e) { for (var t = 1; t < arguments.length; t++) { var n = arguments[t]; for (var o in n) Object.prototype.hasOwnProperty.call(n, o) && (e[o] = n[o]) } return e }), W = D({}, o), U = [], K = void 0, R = function (e) { var r = d(); for (var i in e) o.hasOwnProperty(i) || "extraParams" === i || console.warn('SweetAlert2: Unknown parameter "' + i + '"'); r.style.width = "number" == typeof e.width ? e.width + "px" : e.width, r.style.padding = e.padding + "px", r.style.background = e.background; var a = f(), l = m(), s = b(), c = w(), u = C(); if (e.titleText ? a.innerText = e.titleText : a.innerHTML = e.title.split("\n").join("<br>"), e.text || e.html) { if ("object" === I(e.html)) if (l.innerHTML = "", 0 in e.html) for (var g = 0; g in e.html; g++) l.appendChild(e.html[g].cloneNode(!0)); else l.appendChild(e.html.cloneNode(!0)); else e.html ? l.innerHTML = e.html : e.text && (l.textContent = e.text); P(l) } else L(l); e.showCloseButton ? P(u) : L(u), r.className = t.modal, e.customClass && E(r, e.customClass); var k = y(), S = parseInt(null === e.currentProgressStep ? $.getQueueStep() : e.currentProgressStep, 10); e.progressSteps.length ? (P(k), q(k), S >= e.progressSteps.length && console.warn("SweetAlert2: Invalid currentProgressStep parameter, it should be less than progressSteps.length (currentProgressStep like JS arrays starts from 0)"), e.progressSteps.forEach(function (n, o) { var r = document.createElement("li"); if (E(r, t.progresscircle), r.innerHTML = n, o === S && E(r, t.activeprogressstep), k.appendChild(r), o !== e.progressSteps.length - 1) { var i = document.createElement("li"); E(i, t.progressline), i.style.width = e.progressStepsDistance, k.appendChild(i) } })) : L(k); for (var x = p(), B = 0; B < x.length; B++) L(x[B]); if (e.type) { var T = !1; for (var V in n) if (e.type === V) { T = !0; break } if (!T) return console.error("SweetAlert2: Unknown alert type: " + e.type), !1; var H = r.querySelector("." + t.icon + "." + n[e.type]); switch (P(H), e.type) { case "success": E(H, "animate"), E(H.querySelector(".tip"), "animate-success-tip"), E(H.querySelector(".long"), "animate-success-long"); break; case "error": E(H, "animate-error-icon"), E(H.querySelector(".x-mark"), "animate-x-mark"); break; case "warning": E(H, "pulse-warning") } } var O = v(); e.imageUrl ? (O.setAttribute("src", e.imageUrl), P(O), e.imageWidth ? O.setAttribute("width", e.imageWidth) : O.removeAttribute("width"), e.imageHeight ? O.setAttribute("height", e.imageHeight) : O.removeAttribute("height"), O.className = t.image, e.imageClass && E(O, e.imageClass)) : L(O), e.showCancelButton ? c.style.display = "inline-block" : L(c), e.showConfirmButton ? M(s, "display") : L(s); var N = h(); e.showConfirmButton || e.showCancelButton ? P(N) : L(N), s.innerHTML = e.confirmButtonText, c.innerHTML = e.cancelButtonText, e.buttonsStyling && (s.style.backgroundColor = e.confirmButtonColor, c.style.backgroundColor = e.cancelButtonColor), s.className = t.confirm, E(s, e.confirmButtonClass), c.className = t.cancel, E(c, e.cancelButtonClass), e.buttonsStyling ? (E(s, t.styled), E(c, t.styled)) : (A(s, t.styled), A(c, t.styled), s.style.backgroundColor = s.style.borderLeftColor = s.style.borderRightColor = "", c.style.backgroundColor = c.style.borderLeftColor = c.style.borderRightColor = ""), !0 === e.animation ? A(r, t.noanimation) : E(r, t.noanimation) }, _ = function (e, n) { var o = d(); e ? (E(o, t.show), E(i, t.fade), A(o, t.hide)) : A(o, t.fade), P(o), i.style.overflowY = "hidden", H && !S(o, t.noanimation) ? o.addEventListener(H, function e() { o.removeEventListener(H, e), i.style.overflowY = "auto" }) : i.style.overflowY = "auto", E(i, t.in), E(document.body, t.in), z(), Y(), s.previousActiveElement = document.activeElement, null !== n && "function" == typeof n && n(o) }, z = function () { null === s.previousBodyPadding && document.body.scrollHeight > window.innerHeight && (s.previousBodyPadding = document.body.style.paddingRight, document.body.style.paddingRight = N() + "px") }, Q = function () { null !== s.previousBodyPadding && (document.body.style.paddingRight = s.previousBodyPadding, s.previousBodyPadding = null) }, Y = function () { if (/iPad|iPhone|iPod/.test(navigator.userAgent) && !window.MSStream && !S(document.body, t.iosfix)) { var e = document.body.scrollTop; document.body.style.top = -1 * e + "px", E(document.body, t.iosfix) } }, Z = function () { if (S(document.body, t.iosfix)) { var e = parseInt(document.body.style.top, 10); A(document.body, t.iosfix), document.body.style.top = "", document.body.scrollTop = -1 * e } }, J = function () { for (var e = arguments.length, n = Array(e), o = 0; o < e; o++) n[o] = arguments[o]; if (void 0 === n[0]) return console.error("SweetAlert2 expects at least 1 attribute!"), !1; var r = D({}, W); switch (I(n[0])) { case "string": r.title = n[0], r.html = n[1], r.type = n[2]; break; case "object": D(r, n[0]), r.extraParams = n[0].extraParams, "email" === r.input && null === r.inputValidator && (r.inputValidator = function (e) { return new Promise(function (t, n) { /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/.test(e) ? t() : n("Invalid email address") }) }); break; default: return console.error('SweetAlert2: Unexpected type of argument! Expected "string" or "object", got ' + I(n[0])), !1 } R(r); var a = d(); return new Promise(function (e, n) { r.timer && (a.timeout = setTimeout(function () { $.closeModal(r.onClose), n("timer") }, r.timer)); var o = function (e) { switch (e = e || r.input) { case "select": case "textarea": case "file": return B(a, t[e]); case "checkbox": return a.querySelector("." + t.checkbox + " input"); case "radio": return a.querySelector("." + t.radio + " input:checked") || a.querySelector("." + t.radio + " input:first-child"); case "range": return a.querySelector("." + t.range + " input"); default: return B(a, t.input) } }, c = function () { var e = o(); if (!e) return null; switch (r.input) { case "checkbox": return e.checked ? 1 : 0; case "radio": return e.checked ? e.value : null; case "file": return e.files.length ? e.files[0] : null; default: return r.inputAutoTrim ? e.value.trim() : e.value } }; r.input && setTimeout(function () { var e = o(); e && x(e) }, 0); for (var u = function (t) { r.showLoaderOnConfirm && $.showLoading(), r.preConfirm ? r.preConfirm(t, r.extraParams).then(function (n) { $.closeModal(r.onClose), e(n || t) }, function (e) { $.hideLoading(), e && $.showValidationError(e) }) : ($.closeModal(r.onClose), e(t)) }, p = function (e) { var t = e || window.event, o = t.target || t.srcElement, i = b(), a = w(), s = i === o || i.contains(o), d = a === o || a.contains(o); switch (t.type) { case "mouseover": case "mouseup": r.buttonsStyling && (s ? i.style.backgroundColor = l(r.confirmButtonColor, -.1) : d && (a.style.backgroundColor = l(r.cancelButtonColor, -.1))); break; case "mouseout": r.buttonsStyling && (s ? i.style.backgroundColor = r.confirmButtonColor : d && (a.style.backgroundColor = r.cancelButtonColor)); break; case "mousedown": r.buttonsStyling && (s ? i.style.backgroundColor = l(r.confirmButtonColor, -.2) : d && (a.style.backgroundColor = l(r.cancelButtonColor, -.2))); break; case "click": s && $.isVisible() ? r.input ? function () { var e = c(); r.inputValidator ? ($.disableInput(), r.inputValidator(e, r.extraParams).then(function () { $.enableInput(), u(e) }, function (e) { $.enableInput(), e && $.showValidationError(e) })) : u(e) }() : u(!0) : d && $.isVisible() && ($.closeModal(r.onClose), n("cancel")) } }, f = a.querySelectorAll("button"), m = 0; m < f.length; m++) f[m].onclick = p, f[m].onmouseover = p, f[m].onmouseout = p, f[m].onmousedown = p; C().onclick = function () { $.closeModal(r.onClose), n("close") }, i.onclick = function (e) { e.target === i && r.allowOutsideClick && ($.closeModal(r.onClose), n("overlay")) }; var v = b(), S = w(); r.reverseButtons ? v.parentNode.insertBefore(S, v) : v.parentNode.insertBefore(v, S); var q = function (e, t) { for (var n = k(r.focusCancel), o = 0; o < n.length; o++) { (e += t) === n.length ? e = 0 : -1 === e && (e = n.length - 1); var i = n[e]; if (T(i)) return i.focus() } }; s.previousWindowKeyDown = window.onkeydown, window.onkeydown = function (e) { var t = e || window.event, o = t.keyCode || t.which; if (-1 !== [9, 13, 32, 27].indexOf(o)) { for (var i = t.target || t.srcElement, a = k(r.focusCancel), l = -1, s = 0; s < a.length; s++) if (i === a[s]) { l = s; break } 9 === o ? (t.shiftKey ? q(l, -1) : q(l, 1), t.stopPropagation(), t.preventDefault()) : 13 === o || 32 === o ? -1 === l && V(r.focusCancel ? S : v) : 27 === o && !0 === r.allowEscapeKey && ($.closeModal(r.onClose), n("esc")) } }, r.buttonsStyling && (v.style.borderLeftColor = r.confirmButtonColor, v.style.borderRightColor = r.confirmButtonColor), $.showLoading = $.enableLoading = function () { P(h()), P(v, "inline-block"), E(v, t.loading), E(a, t.loading), v.disabled = !0, S.disabled = !0 }, $.hideLoading = $.disableLoading = function () { r.showConfirmButton || (L(v), r.showCancelButton || L(h())), A(v, t.loading), A(a, t.loading), v.disabled = !1, S.disabled = !1 }, $.enableButtons = function () { v.disabled = !1, S.disabled = !1 }, $.disableButtons = function () { v.disabled = !0, S.disabled = !0 }, $.enableConfirmButton = function () { v.disabled = !1 }, $.disableConfirmButton = function () { v.disabled = !0 }, $.enableInput = function () { var e = o(); if (!e) return !1; if ("radio" === e.type) for (var t = e.parentNode.parentNode.querySelectorAll("input"), n = 0; n < t.length; n++) t[n].disabled = !1; else e.disabled = !1 }, $.disableInput = function () { var e = o(); if (!e) return !1; if (e && "radio" === e.type) for (var t = e.parentNode.parentNode.querySelectorAll("input"), n = 0; n < t.length; n++) t[n].disabled = !0; else e.disabled = !0 }, $.recalculateHeight = j(function () { var e = d(), t = e.style.display; e.style.minHeight = "", P(e), e.style.minHeight = e.scrollHeight + 1 + "px", e.style.display = t }, 50), $.showValidationError = function (e) { var n = g(); n.innerHTML = e, P(n); var r = o(); x(r), E(r, t.inputerror) }, $.resetValidationError = function () { var e = g(); L(e), $.recalculateHeight(); var n = o(); n && A(n, t.inputerror) }, $.getProgressSteps = function () { return r.progressSteps }, $.setProgressSteps = function (e) { r.progressSteps = e, R(r) }, $.showProgressSteps = function () { P(y()) }, $.hideProgressSteps = function () { L(y()) }, $.enableButtons(), $.hideLoading(), $.resetValidationError(); for (var M = ["input", "file", "range", "select", "radio", "checkbox", "textarea"], H = void 0, O = 0; O < M.length; O++) { var N = t[M[O]], D = B(a, N); if (H = o(M[O])) { for (var W in H.attributes) if (H.attributes.hasOwnProperty(W)) { var U = H.attributes[W].name; "type" !== U && "value" !== U && H.removeAttribute(U) } for (var z in r.inputAttributes) H.setAttribute(z, r.inputAttributes[z]) } D.className = N, r.inputClass && E(D, r.inputClass), L(D) } var Q = void 0; !function () { switch (r.input) { case "text": case "email": case "password": case "number": case "tel": (H = B(a, t.input)).value = r.inputValue, H.placeholder = r.inputPlaceholder, H.type = r.input, P(H); break; case "file": (H = B(a, t.file)).placeholder = r.inputPlaceholder, H.type = r.input, P(H); break; case "range": var e = B(a, t.range), n = e.querySelector("input"), i = e.querySelector("output"); n.value = r.inputValue, n.type = r.input, i.value = r.inputValue, P(e); break; case "select": var l = B(a, t.select); if (l.innerHTML = "", r.inputPlaceholder) { var s = document.createElement("option"); s.innerHTML = r.inputPlaceholder, s.value = "", s.disabled = !0, s.selected = !0, l.appendChild(s) } Q = function (e) { for (var t in e) { var n = document.createElement("option"); n.value = t, n.innerHTML = e[t], r.inputValue === t && (n.selected = !0), l.appendChild(n) } P(l), l.focus() }; break; case "radio": var c = B(a, t.radio); c.innerHTML = "", Q = function (e) { for (var n in e) { var o = 1, i = document.createElement("input"), a = document.createElement("label"), l = document.createElement("span"); i.type = "radio", i.name = t.radio, i.value = n, i.id = t.radio + "-" + o++, r.inputValue === n && (i.checked = !0), l.innerHTML = e[n], a.appendChild(i), a.appendChild(l), a.for = i.id, c.appendChild(a) } P(c); var s = c.querySelectorAll("input"); s.length && s[0].focus() }; break; case "checkbox": var u = B(a, t.checkbox), d = o("checkbox"); d.type = "checkbox", d.value = 1, d.id = t.checkbox, d.checked = Boolean(r.inputValue); var p = u.getElementsByTagName("span"); p.length && u.removeChild(p[0]), (p = document.createElement("span")).innerHTML = r.inputPlaceholder, u.appendChild(p), P(u); break; case "textarea": var f = B(a, t.textarea); f.value = r.inputValue, f.placeholder = r.inputPlaceholder, P(f); break; case null: break; default: console.error('SweetAlert2: Unexpected type of input! Expected "text", "email", "password", "select", "checkbox", "textarea" or "file", got "' + r.input + '"') } }(), "select" !== r.input && "radio" !== r.input || (r.inputOptions instanceof Promise ? ($.showLoading(), r.inputOptions.then(function (e) { $.hideLoading(), Q(e) })) : "object" === I(r.inputOptions) ? Q(r.inputOptions) : console.error("SweetAlert2: Unexpected type of inputOptions! Expected object or Promise, got " + I(r.inputOptions))), _(r.animation, r.onOpen), q(-1, 1), i.scrollTop = 0, "undefined" == typeof MutationObserver || K || (K = new MutationObserver($.recalculateHeight)).observe(a, { childList: !0, characterData: !0, subtree: !0 }) }) }, $ = function e() { for (var t = arguments.length, n = Array(t), o = 0; o < t; o++) n[o] = arguments[o]; return e.isVisible() && e.close(), J.apply(void 0, n) }; return $.isVisible = function () { var e = d(); return T(e) }, $.queue = function (e) { U = e; var t = d(), n = function () { U = [], t.removeAttribute("data-queue-step") }, o = []; return new Promise(function (e, r) { !function i(a, l) { a < U.length ? (t.setAttribute("data-queue-step", a), $(U[a]).then(function (e) { o.push(e), i(a + 1, l) }, function (e) { n(), r(e) })) : (n(), e(o)) }(0) }) }, $.getQueueStep = function () { return d().getAttribute("data-queue-step") }, $.insertQueueStep = function (e, t) { return t && t < U.length ? U.splice(t, 0, e) : U.push(e) }, $.deleteQueueStep = function (e) { void 0 !== U[e] && U.splice(e, 1) }, $.close = $.closeModal = function (e) { var o = d(); A(o, t.show), E(o, t.hide); var r = o.querySelector("." + t.icon + "." + n.success); A(r, "animate"), A(r.querySelector(".tip"), "animate-success-tip"), A(r.querySelector(".long"), "animate-success-long"); var a = o.querySelector("." + t.icon + "." + n.error); A(a, "animate-error-icon"), A(a.querySelector(".x-mark"), "animate-x-mark"); var l = o.querySelector("." + t.icon + "." + n.warning); A(l, "pulse-warning"), O(); var s = function () { L(o), o.style.minHeight = "", A(i, t.in), A(document.body, t.in), Q(), Z() }; H && !S(o, t.noanimation) ? o.addEventListener(H, function e() { o.removeEventListener(H, e), S(o, t.hide) && s() }) : s(), null !== e && "function" == typeof e && e(o) }, $.clickConfirm = function () { return b().click() }, $.clickCancel = function () { return w().click() }, $.setDefaults = function (e) { if (!e || "object" !== (void 0 === e ? "undefined" : I(e))) return console.error("SweetAlert2: the argument for setDefaults() is required and has to be a object"); for (var t in e) o.hasOwnProperty(t) || "extraParams" === t || (console.warn('SweetAlert2: Unknown parameter "' + t + '"'), delete e[t]); D(W, e) }, $.resetDefaults = function () { W = D({}, o) }, $.noop = function () { }, $.version = "6.2.9", $ }), window.Sweetalert2 && (window.sweetAlert = window.swal = window.Sweetalert2);