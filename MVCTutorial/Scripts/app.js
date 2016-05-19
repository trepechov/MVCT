var app = (function () {
    var isUserAuthenticated, contentId;

    function configureRequireJs() {
        requirejs.config({
            baseUrl: '/Scripts/app',
            paths: {
                controllers: 'controllers',
                common: 'common',
                libs: '../libs',
            }
        });
    }

    function mapParams(params) {
        contentId = params.contentId;
        isUserAuthenticated = params.isUserAuthenticated == 'True' ? true : false;
    }

    function loadContent() {
        require(['common/services/loader'], function (loader) {
            if (!isUserAuthenticated) {
                loader.load(contentId, '/Account/Login');
            } else {
                loader.load(contentId, '/Home/Home');
            }
        });
    }

    return {
        init: function (params) {
            configureRequireJs();
            mapParams(params);
            loadContent();
        }
    };
})();