var utils = (function () {
    return {
        isEmptyArray: function (param) {
            var arr = ko.unwrap(param);
            if (!this.isNullOrUndefined(arr)) {
                return arr.length === 0;
            } else {
                return true;
            }
        },
        isNull: function (param) {
            return param === null;
        },
        isUndefined: function (param) {
            return param === undefined;
        },
        isNullOrUndefined: function (param) {
            return this.isNull(param) || this.isUndefined(param);
        },
        cleanNode: function (nodeId) {
            ko.cleanNode(document.getElementById(nodeId));
        },
        getNodeContext: function (nodeId) {
            return ko.dataFor(document.getElementById(nodeId));
        }
    };
})();