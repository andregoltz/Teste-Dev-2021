"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ClientDataService = void 0;
var ClientDataService = /** @class */ (function () {
    function ClientDataService(http) {
        this.http = http;
        this.module = '/api/clients';
    }
    ClientDataService.prototype.get = function () {
        return this.http.get(this.module);
    };
    return ClientDataService;
}());
exports.ClientDataService = ClientDataService;
//# sourceMappingURL=client.data-service.js.map