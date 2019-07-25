app.service('crudService', function ($http) {

    //Get All products
    this.getAll = function () {
        return $http.get("/api/GetAllproducts");
    }


    //Get Single product
    this.get = function (Id) {
        return $http.get("/api/GetProduct/" + Id);
    }



    //Create new product
    this.post = function (newproduct) {
        var request = $http({
            method: "post",
            url: "/api/InsertnewProduct/" + newproduct,
            data: newproduct
        });
        return request;
    }
   

   


    //Update the product
    this.put = function (updatedproduct) {
        var request = $http({
            method: "put",
            url: "/api/UpdateProductDetails/" + updatedproduct,
            data: updatedproduct
        });
        return request;
    }

    //Delete the product
    this.delete = function (Id) {
        var request = $http({
            method: "delete",
            url: "/api/Deleteproduct/" + Id
        });
        return request;
    }
});