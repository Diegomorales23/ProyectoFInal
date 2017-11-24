type = ["", "info", "success", "warning", "danger"], $().ready(function () { $sidebar = $(".sidebar"), $off_canvas_sidebar = $(".off-canvas-sidebar"), window_width = $(window).width(), window_width > 767 && $(".fixed-plugin .dropdown").hasClass("show-dropdown") && $(".fixed-plugin .dropdown").addClass("open"), $(".fixed-plugin a").click(function (e) { $(this).hasClass("switch-trigger") && (e.stopPropagation ? e.stopPropagation() : window.event && (window.event.cancelBubble = !0)) }), $(".fixed-plugin .background-color span").click(function () { $(this).siblings().removeClass("active"), $(this).addClass("active"); var e = $(this).data("color"); 0 != $sidebar.length && $sidebar.attr("data-background-color", e), 0 != $off_canvas_sidebar.length && $off_canvas_sidebar.attr("data-background-color", e) }), $(".fixed-plugin .active-color span").click(function () { $(this).siblings().removeClass("active"), $(this).addClass("active"); var e = $(this).data("color"); 0 != $sidebar.length && $sidebar.attr("data-active-color", e), 0 != $off_canvas_sidebar.length && $off_canvas_sidebar.attr("data-active-color", e) }), 0 != $("#twitter").length && $("#twitter").sharrre({ share: { twitter: !0 }, enableHover: !1, enableTracking: !0, buttons: { twitter: { via: "CreativeTim" } }, click: function (e, t) { e.simulateClick(), e.openPopup("twitter") }, template: '<i class="fa fa-twitter"></i>', url: "http://demos.creative-tim.com/paper-dashboard-pro/examples/dashboard/overview.html" }), 0 != $("#facebook").length && $("#facebook").sharrre({ share: { facebook: !0 }, enableHover: !1, enableTracking: !0, click: function (e, t) { e.simulateClick(), e.openPopup("facebook") }, template: '<i class="fa fa-facebook-square"></i>', url: "http://demos.creative-tim.com/paper-dashboard-pro/examples/dashboard/overview.html" }) }), demo = { initCirclePercentage: function () { $("#chartDashboard, #chartOrders, #chartNewVisitors, #chartSubscriptions, #chartDashboardDoc, #chartOrdersDoc").easyPieChart({ lineWidth: 6, size: 160, scaleColor: !1, trackColor: "rgba(255,255,255,.25)", barColor: "#FFFFFF", animate: { duration: 5e3, enabled: !0 } }) }, initGoogleMaps: function () { var e = new google.maps.LatLng(40.748817, -73.985428), t = { zoom: 3, scrollwheel: !1, center: e, mapTypeId: google.maps.MapTypeId.SATELLITE }, a = new google.maps.Map(document.getElementById("satelliteMap"), t); new google.maps.Marker({ position: e, title: "Satellite Map!" }).setMap(a) }, initSmallGoogleMaps: function () { var e = new google.maps.LatLng(40.748817, -73.985428), t = { zoom: 8, center: e, scrollwheel: !1 }, a = new google.maps.Map(document.getElementById("regularMap"), t), i = new google.maps.Marker({ position: e, title: "Regular Map!" }); i.setMap(a); var t = { zoom: 13, center: e = new google.maps.LatLng(40.748817, -73.985428), scrollwheel: !1, disableDefaultUI: !0, zoomControl: !0, styles: [{ featureType: "water", stylers: [{ saturation: 43 }, { lightness: -11 }, { hue: "#0088ff" }] }, { featureType: "road", elementType: "geometry.fill", stylers: [{ hue: "#ff0000" }, { saturation: -100 }, { lightness: 99 }] }, { featureType: "road", elementType: "geometry.stroke", stylers: [{ color: "#808080" }, { lightness: 54 }] }, { featureType: "landscape.man_made", elementType: "geometry.fill", stylers: [{ color: "#ece2d9" }] }, { featureType: "poi.park", elementType: "geometry.fill", stylers: [{ color: "#ccdca1" }] }, { featureType: "road", elementType: "labels.text.fill", stylers: [{ color: "#767676" }] }, { featureType: "road", elementType: "labels.text.stroke", stylers: [{ color: "#ffffff" }] }, { featureType: "poi", stylers: [{ visibility: "off" }] }, { featureType: "landscape.natural", elementType: "geometry.fill", stylers: [{ visibility: "on" }, { color: "#b8cb93" }] }, { featureType: "poi.park", stylers: [{ visibility: "on" }] }, { featureType: "poi.sports_complex", stylers: [{ visibility: "on" }] }, { featureType: "poi.medical", stylers: [{ visibility: "on" }] }, { featureType: "poi.business", stylers: [{ visibility: "simplified" }] }] }, a = new google.maps.Map(document.getElementById("customSkinMap"), t); (i = new google.maps.Marker({ position: e, title: "Custom Skin & Settings Map!" })).setMap(a) }, initVectorMap: function () { var e = { AU: 760, BR: 550, CA: 120, DE: 1300, FR: 540, GB: 690, GE: 200, IN: 200, RO: 600, RU: 300, US: 2920 }; $("#worldMap").vectorMap({ map: "world_mill_en", backgroundColor: "transparent", zoomOnScroll: !1, regionStyle: { initial: { fill: "#e4e4e4", "fill-opacity": .9, stroke: "none", "stroke-width": 0, "stroke-opacity": 0 } }, series: { regions: [{ values: e, scale: ["#AAAAAA", "#444444"], normalizeFunction: "polynomial" }] } }) }, initFullScreenGoogleMap: function () { var e = new google.maps.LatLng(40.748817, -73.985428), t = { zoom: 13, center: e, scrollwheel: !1, styles: [{ featureType: "water", stylers: [{ saturation: 43 }, { lightness: -11 }, { hue: "#0088ff" }] }, { featureType: "road", elementType: "geometry.fill", stylers: [{ hue: "#ff0000" }, { saturation: -100 }, { lightness: 99 }] }, { featureType: "road", elementType: "geometry.stroke", stylers: [{ color: "#808080" }, { lightness: 54 }] }, { featureType: "landscape.man_made", elementType: "geometry.fill", stylers: [{ color: "#ece2d9" }] }, { featureType: "poi.park", elementType: "geometry.fill", stylers: [{ color: "#ccdca1" }] }, { featureType: "road", elementType: "labels.text.fill", stylers: [{ color: "#767676" }] }, { featureType: "road", elementType: "labels.text.stroke", stylers: [{ color: "#ffffff" }] }, { featureType: "poi", stylers: [{ visibility: "off" }] }, { featureType: "landscape.natural", elementType: "geometry.fill", stylers: [{ visibility: "on" }, { color: "#b8cb93" }] }, { featureType: "poi.park", stylers: [{ visibility: "on" }] }, { featureType: "poi.sports_complex", stylers: [{ visibility: "on" }] }, { featureType: "poi.medical", stylers: [{ visibility: "on" }] }, { featureType: "poi.business", stylers: [{ visibility: "simplified" }] }] }, a = new google.maps.Map(document.getElementById("map"), t); new google.maps.Marker({ position: e, title: "Hello World!" }).setMap(a) }, initOverviewDashboardDoc: function () { var e = { labels: ["Jan", "Feb", "Mar", "April", "May", "June"], series: [[230, 340, 400, 300, 570, 500, 800]] }, t = { showPoint: !1, lineSmooth: !0, height: "210px", axisX: { showGrid: !1, showLabel: !0 }, axisY: { offset: 40, showGrid: !1 }, low: 0, high: "auto", classNames: { line: "ct-line ct-green" } }; Chartist.Line("#chartTotalEarningsDoc", e, t); var a = { labels: ["M", "T", "W", "T", "F", "S", "S"], series: [[60, 50, 30, 50, 70, 60, 90, 100]] }, i = { showPoint: !1, lineSmooth: !0, height: "210px", axisX: { showGrid: !1, showLabel: !0 }, axisY: { offset: 40, showGrid: !1 }, low: 0, high: "auto", classNames: { line: "ct-line ct-red" } }; Chartist.Line("#chartTotalSubscriptionsDoc", a, i) }, initOverviewDashboard: function () { var e = { labels: ["Jan", "Feb", "Mar", "April", "May", "June"], series: [[230, 340, 400, 300, 570, 500, 800]] }, t = { showPoint: !1, lineSmooth: !0, height: "210px", axisX: { showGrid: !1, showLabel: !0 }, axisY: { offset: 40, showGrid: !1 }, low: 0, high: "auto", classNames: { line: "ct-line ct-green" } }; Chartist.Line("#chartTotalEarnings", e, t); var a = { labels: ["M", "T", "W", "T", "F", "S", "S"], series: [[60, 50, 30, 50, 70, 60, 90, 100]] }, i = { showPoint: !1, lineSmooth: !0, height: "210px", axisX: { showGrid: !1, showLabel: !0 }, axisY: { offset: 40, showGrid: !1 }, low: 0, high: "auto", classNames: { line: "ct-line ct-red" } }; Chartist.Line("#chartTotalSubscriptions", a, i); var n = { labels: ["2009", "2010", "2011", "2012", "2013", "2014"], series: [[1200, 1e3, 3490, 8345, 3256, 2566]] }, s = { showPoint: !1, lineSmooth: !0, height: "210px", axisX: { showGrid: !1, showLabel: !0 }, axisY: { offset: 40, showGrid: !1 }, low: 0, high: "auto", classNames: { line: "ct-line ct-orange" } }; Chartist.Line("#chartTotalDownloads", n, s) }, initStatsDashboard: function () { var e = { labels: ["9:00AM", "12:00AM", "3:00PM", "6:00PM", "9:00PM", "12:00PM", "3:00AM", "6:00AM"], series: [[287, 385, 490, 562, 594, 626, 698, 895, 952], [67, 152, 193, 240, 387, 435, 535, 642, 744], [23, 113, 67, 108, 190, 239, 307, 410, 410]] }, t = { lineSmooth: !1, low: 0, high: 1e3, showArea: !0, height: "245px", axisX: { showGrid: !1 }, lineSmooth: Chartist.Interpolation.simple({ divisor: 3 }), showLine: !0, showPoint: !1 }, a = [["screen and (max-width: 640px)", { axisX: { labelInterpolationFnc: function (e) { return e[0] } } }]]; Chartist.Line("#chartHours", e, t, a); var i = { labels: ["Jan", "Feb", "Mar", "Apr", "Mai", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"], series: [[542, 543, 520, 680, 653, 753, 326, 434, 568, 610, 756, 895], [230, 293, 380, 480, 503, 553, 600, 664, 698, 710, 736, 795]] }, n = { seriesBarDistance: 10, axisX: { showGrid: !1 }, height: "245px" }, s = [["screen and (max-width: 640px)", { seriesBarDistance: 5, axisX: { labelInterpolationFnc: function (e) { return e[0] } } }]]; Chartist.Line("#chartActivity", i, n, s), Chartist.Pie("#chartPreferences", { labels: ["62%", "32%", "6%"], series: [62, 32, 6] }) }, initChartsPage: function () { var e = { labels: ["6pm", "9pm", "11pm", "2am", "4am", "8am", "2pm", "5pm", "8pm", "11pm", "4am"], series: [[1, 6, 8, 7, 4, 7, 8, 12, 16, 17, 14, 13]] }, t = { showPoint: !1, lineSmooth: !0, height: "200px", axisX: { showGrid: !1, showLabel: !0 }, axisY: { offset: 40 }, low: 0, high: 16, height: "250px" }; Chartist.Line("#chartPerformance", e, t); var a = { labels: ["Jan", "Feb", "Mar", "Apr", "Mai", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"], series: [[542, 443, 320, 780, 553, 453, 326, 434, 568, 610, 756, 895], [412, 243, 280, 580, 453, 353, 300, 364, 368, 410, 636, 695]] }, i = { seriesBarDistance: 10, axisX: { showGrid: !1 }, height: "250px" }, n = [["screen and (max-width: 640px)", { seriesBarDistance: 5, axisX: { labelInterpolationFnc: function (e) { return e[0] } } }]]; Chartist.Bar("#chartActivity", a, i, n); var s = { labels: ["'07", "'08", "'09", "'10", "'11", "'12", "'13", "'14", "'15"], series: [[22.2, 34.9, 42.28, 51.93, 62.21, 80.23, 62.21, 82.12, 102.5, 107.23]] }, o = { lineSmooth: !1, height: "200px", axisY: { offset: 40, labelInterpolationFnc: function (e) { return "$" + e } }, low: 10, height: "250px", high: 110, classNames: { point: "ct-point ct-green", line: "ct-line ct-green" } }; Chartist.Line("#chartStock", s, o); var r = { labels: ["Jan", "Feb", "Mar", "Apr", "Mai", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"], series: [[542, 443, 320, 780, 553, 453, 326, 434, 568, 610, 756, 895]] }, l = { seriesBarDistance: 10, classNames: { bar: "ct-bar" }, axisX: { showGrid: !1 }, height: "250px" }, c = [["screen and (max-width: 640px)", { seriesBarDistance: 5, axisX: { labelInterpolationFnc: function (e) { return e[0] } } }]]; Chartist.Bar("#chartViews", r, l, c) }, showSwal: function (e) { "basic" == e ? swal({ title: "Here's a message!", buttonsStyling: !1, confirmButtonClass: "btn btn-success btn-fill" }) : "title-and-text" == e ? swal({ title: "Here's a message!", text: "It's pretty, isn't it?", buttonsStyling: !1, confirmButtonClass: "btn btn-info btn-fill" }) : "success-message" == e ? swal({ title: "Good job!", text: "You clicked the button!", buttonsStyling: !1, confirmButtonClass: "btn btn-success btn-fill", type: "success" }) : "warning-message-and-confirmation" == e ? swal({ title: "Are you sure?", text: "You won't be able to revert this!", type: "warning", showCancelButton: !0, confirmButtonClass: "btn btn-success btn-fill", cancelButtonClass: "btn btn-danger btn-fill", confirmButtonText: "Yes, delete it!", buttonsStyling: !1 }).then(function () { swal({ title: "Deleted!", text: "Your file has been deleted.", type: "success", confirmButtonClass: "btn btn-success btn-fill", buttonsStyling: !1 }) }) : "warning-message-and-cancel" == e ? swal({ title: "Are you sure?", text: "You will not be able to recover this imaginary file!", type: "warning", showCancelButton: !0, confirmButtonText: "Yes, delete it!", cancelButtonText: "No, keep it", confirmButtonClass: "btn btn-success btn-fill", cancelButtonClass: "btn btn-danger btn-fill", buttonsStyling: !1 }).then(function () { swal({ title: "Deleted!", text: "Your imaginary file has been deleted.", type: "success", confirmButtonClass: "btn btn-success btn-fill", buttonsStyling: !1 }) }, function (e) { "cancel" === e && swal({ title: "Cancelled", text: "Your imaginary file is safe :)", type: "error", confirmButtonClass: "btn btn-info btn-fill", buttonsStyling: !1 }) }) : "custom-html" == e ? swal({ title: "HTML example", buttonsStyling: !1, confirmButtonClass: "btn btn-success btn-fill", html: 'You can use <b>bold text</b>, <a href="http://github.com">links</a> and other HTML tags' }) : "auto-close" == e ? swal({ title: "Auto close alert!", text: "I will close in 2 seconds.", timer: 2e3, showConfirmButton: !1 }) : "input-field" == e && swal({ title: "Input something", html: '<div class="form-group"><input id="input-field" type="text" class="form-control" /></div>', showCancelButton: !0, confirmButtonClass: "btn btn-success btn-fill", cancelButtonClass: "btn btn-danger btn-fill", buttonsStyling: !1 }).then(function (e) { swal({ type: "success", html: "You entered: <strong>" + $("#input-field").val() + "</strong>", confirmButtonClass: "btn btn-success btn-fill", buttonsStyling: !1 }) }).catch(swal.noop) }, checkFullPageBackgroundImage: function () { $page = $(".full-page"), image_src = $page.data("image"), void 0 !== image_src && (image_container = '<div class="full-page-background" style="background-image: url(' + image_src + ') "/>', $page.append(image_container)) }, initWizard: function () { $(document).ready(function () { var e = $("#wizardForm").validate({ rules: { email: { required: !0, email: !0, minlength: 5 }, first_name: { required: !1, minlength: 5 }, last_name: { required: !1, minlength: 5 }, website: { required: !0, minlength: 5, url: !0 }, framework: { required: !1, minlength: 4 }, cities: { required: !0 }, price: { number: !0 } } }); $("#wizardCard").bootstrapWizard({ tabClass: "nav nav-pills", nextSelector: ".btn-next", previousSelector: ".btn-back", onNext: function (t, a, i) { if (!$("#wizardForm").valid()) return e.focusInvalid(), !1 }, onInit: function (e, t, a) { var i = t.find("li").length; $width = 100 / i, $display_width = $(document).width(), $display_width < 600 && i > 3 && ($width = 50), t.find("li").css("width", $width + "%") }, onTabClick: function (e, t, a) { return !1 }, onTabShow: function (e, t, a) { var i = t.find("li").length, n = a + 1, s = t.closest(".card-wizard"); n >= i ? ($(s).find(".btn-next").hide(), $(s).find(".btn-finish").show()) : 1 == n ? $(s).find(".btn-back").hide() : ($(s).find(".btn-back").show(), $(s).find(".btn-next").show(), $(s).find(".btn-finish").hide()) } }) }) }, initFormExtendedSliders: function () { var e = document.getElementById("sliderRegular"); noUiSlider.create(e, { start: 40, connect: [!0, !1], range: { min: 0, max: 100 } }); var t = document.getElementById("sliderDouble"); noUiSlider.create(t, { start: [20, 60], connect: !0, range: { min: 0, max: 100 } }) }, initFormExtendedDatetimepickers: function () { $(".datetimepicker").datetimepicker({ icons: { time: "fa fa-clock-o", date: "fa fa-calendar", up: "fa fa-chevron-up", down: "fa fa-chevron-down", previous: "fa fa-chevron-left", next: "fa fa-chevron-right", today: "fa fa-screenshot", clear: "fa fa-trash", close: "fa fa-remove" } }), $(".datepicker").datetimepicker({ format: "MM/DD/YYYY", icons: { time: "fa fa-clock-o", date: "fa fa-calendar", up: "fa fa-chevron-up", down: "fa fa-chevron-down", previous: "fa fa-chevron-left", next: "fa fa-chevron-right", today: "fa fa-screenshot", clear: "fa fa-trash", close: "fa fa-remove" } }), $(".timepicker").datetimepicker({ format: "h:mm A", icons: { time: "fa fa-clock-o", date: "fa fa-calendar", up: "fa fa-chevron-up", down: "fa fa-chevron-down", previous: "fa fa-chevron-left", next: "fa fa-chevron-right", today: "fa fa-screenshot", clear: "fa fa-trash", close: "fa fa-remove" } }) }, initFullCalendar: function () { $calendar = $("#fullCalendar"), today = new Date, y = today.getFullYear(), m = today.getMonth(), d = today.getDate(), $calendar.fullCalendar({ viewRender: function (e, t) { "month" != e.name && $(t).find(".fc-scroller").perfectScrollbar() }, header: { left: "title", center: "month,agendaWeek,agendaDay", right: "prev,next,today" }, defaultDate: today, selectable: !0, selectHelper: !0, views: { month: { titleFormat: "MMMM YYYY" }, week: { titleFormat: " MMMM D YYYY" }, day: { titleFormat: "D MMM, YYYY" } }, select: function (e, t) { swal({ title: "Create an Event", html: '<div class="form-group"><input class="form-control" placeholder="Event Title" id="input-field"></div>', showCancelButton: !0, confirmButtonClass: "btn btn-success", cancelButtonClass: "btn btn-danger", buttonsStyling: !1 }).then(function (a) { var i; event_title = $("#input-field").val(), event_title && (i = { title: event_title, start: e, end: t }, $calendar.fullCalendar("renderEvent", i, !0)), $calendar.fullCalendar("unselect") }) }, editable: !0, eventLimit: !0, events: [{ title: "All Day Event", start: new Date(y, m, 1), className: "event-default" }, { id: 999, title: "Repeating Event", start: new Date(y, m, d - 4, 6, 0), allDay: !1, className: "event-rose" }, { id: 999, title: "Repeating Event", start: new Date(y, m, d + 3, 6, 0), allDay: !1, className: "event-rose" }, { title: "Meeting", start: new Date(y, m, d - 1, 10, 30), allDay: !1, className: "event-green" }, { title: "Lunch", start: new Date(y, m, d + 7, 12, 0), end: new Date(y, m, d + 7, 14, 0), allDay: !1, className: "event-red" }, { title: "Md-pro Launch", start: new Date(y, m, d - 2, 12, 0), allDay: !0, className: "event-azure" }, { title: "Birthday Party", start: new Date(y, m, d + 1, 19, 0), end: new Date(y, m, d + 1, 22, 30), allDay: !1, className: "event-azure" }, { title: "Click for Creative Tim", start: new Date(y, m, 21), end: new Date(y, m, 22), url: "http://www.creative-tim.com/", className: "event-orange" }, { title: "Click for Google", start: new Date(y, m, 21), end: new Date(y, m, 22), url: "http://www.creative-tim.com/", className: "event-orange" }] }) }, showNotification: function (e, t) { color = Math.floor(4 * Math.random() + 1), $.notify({ icon: "ti-gift", message: "Welcome to <b>Paper Dashboard</b> - a beautiful dashboard for every web developer." }, { type: type[color], timer: 4e3, placement: { from: e, align: t } }) }, initDocumentationCharts: function () { var e = { labels: ["6pm", "9pm", "11pm", "2am", "4am", "8am", "2pm", "5pm", "8pm", "11pm", "4am"], series: [[1, 6, 8, 7, 4, 7, 8, 12, 16, 17, 14, 13]] }, t = { showPoint: !1, lineSmooth: !0, height: "200px", axisX: { showGrid: !1, showLabel: !0 }, axisY: { offset: 40 }, low: 0, high: 16, height: "250px" }; Chartist.Line("#chartPerformance", e, t); var a = { labels: ["'07", "'08", "'09", "'10", "'11", "'12", "'13", "'14", "'15"], series: [[22.2, 34.9, 42.28, 51.93, 62.21, 80.23, 62.21, 82.12, 102.5, 107.23]] }, i = { lineSmooth: !1, height: "200px", axisY: { offset: 40, labelInterpolationFnc: function (e) { return "$" + e } }, low: 10, height: "250px", high: 110, classNames: { point: "ct-point ct-green", line: "ct-line ct-green" } }; Chartist.Line("#chartStock", a, i); var n = { labels: ["9:00AM", "12:00AM", "3:00PM", "6:00PM", "9:00PM", "12:00PM", "3:00AM", "6:00AM"], series: [[287, 385, 490, 562, 594, 626, 698, 895, 952], [67, 152, 193, 240, 387, 435, 535, 642, 744], [23, 113, 67, 108, 190, 239, 307, 410, 410]] }, s = { lineSmooth: !1, low: 0, high: 1e3, showArea: !0, height: "245px", axisX: { showGrid: !1 }, lineSmooth: Chartist.Interpolation.simple({ divisor: 3 }), showLine: !0, showPoint: !1 }, o = [["screen and (max-width: 640px)", { axisX: { labelInterpolationFnc: function (e) { return e[0] } } }]]; Chartist.Line("#chartHours", n, s, o), Chartist.Pie("#chartPreferences", { labels: ["62%", "32%", "6%"], series: [62, 32, 6] }); var r = { labels: ["Jan", "Feb", "Mar", "Apr", "Mai", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"], series: [[542, 443, 320, 780, 553, 453, 326, 434, 568, 610, 756, 895]] }, l = { seriesBarDistance: 10, classNames: { bar: "ct-bar" }, axisX: { showGrid: !1 }, height: "250px" }, c = [["screen and (max-width: 640px)", { seriesBarDistance: 5, axisX: { labelInterpolationFnc: function (e) { return e[0] } } }]]; Chartist.Bar("#chartViews", r, l, c); var h = { labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"], series: [[542, 543, 520, 680, 653, 753, 326, 434, 568, 610, 756, 895], [230, 293, 380, 480, 503, 553, 600, 664, 698, 710, 736, 795]] }, d = { seriesBarDistance: 10, axisX: { showGrid: !1 }, height: "245px" }, f = [["screen and (max-width: 640px)", { seriesBarDistance: 5, axisX: { labelInterpolationFnc: function (e) { return e[0] } } }]]; Chartist.Line("#chartActivity", h, d, f) } };