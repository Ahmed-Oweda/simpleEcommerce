

//The controller is having 'crudService' dependency.
//This controller makes call to methods from the service 
app.controller('crudController', function ($scope, crudService) {

    $scope.IsNewRecord = 1; //The flag for the new record

    loadRecords();

    //Function to load all products
    function loadRecords() {
        var promiseGet = crudService.getAll(); //The MEthod Call from service

        promiseGet.then(function (pl) { $scope.products = pl.data },
            function (error) {
                $log.error('Error' + error);
            });
    }

    //Function to update products
    $scope.save = function () {
        var product = {
            Id: $scope.Id,
            Name: $scope.Name,
            NoInStock: $scope.NoInStock,
            price: $scope.price,
            supplier: $scope.supplier
        };
        //If the flag is 1 then new record
        if ($scope.IsNewRecord === 1) {
            var promisePost = crudService.post(product);
            promisePost.then(function (pl) {
                $scope.Id = pl.data.Id;
                loadRecords();
            }, function (error) {
                console.log("Error" + error);
            });
        } else { //Else Edit the record
            var promisePut = crudService.put(product);
            promisePut.then(function (pl) {
                $scope.Message = "Updated Successfuly";
                loadRecords();
            }, function (error) {
                console.log("Error" + error);
            });
        }



    };

    //Method to Delete product
    $scope.delete = function () {
        var promiseDelete = crudService.delete($scope.Id);
        promiseDelete.then(function (pl) {
            $scope.Message = "Deleted Successfuly";
            $scope.Id = 0;
            $scope.Name = "";
            $scope.NoInStock = 0;
            $scope.price = 0;
            $scope.supplier = "";
            loadRecords();
        }, function (error) {
            console.log("Error" + error);
        });
    }

    //Method to Get Single product
    $scope.get = function () {
        var promiseGetSingle = crudService.get($scope.Id);

        promiseGetSingle.then(function (pl) {
            var res = pl.data;
            $scope.Id = res.Id;
            $scope.Name = res.Name;
            $scope.NoInStock = res.NoInStock;
            $scope.price = res.price;
            $scope.supplier = res.supplier;

            $scope.IsNewRecord = 0;
        },
            function (error) {
                console.log("Error" + error);
            });
    }
    //Clear the Scope models
    $scope.clear = function () {
        $scope.IsNewRecord = 1;
        $scope.Id = 0;
        $scope.Name = "";
        $scope.NoInStock = 0;
        $scope.price = 0;
        $scope.supplier = "";
    }
});