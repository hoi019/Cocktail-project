// const minus = document.querySelector('.minus');
// const plus = document.querySelector('.plus');
// const current = document.querySelector('.number');
// var count = 0;

// plus.addEventListener('click', () => {
//   if (count => 0) {
//     count = count + 1;
//     current.innerHTML = count
//   }
// })

// minus.addEventListener('click', () => {
//   if (count > 0) {
//     count = count - 1;
//     current.innerHTML = count
//   }
// })


// var app = angular.module('AppBanHang', []);
// app.controller("ChiTietCtrl", function ($scope, $http) {
//   $scope.sanpham;
//   $scope.GetSanPham = function () {
//     $http({
//       method: 'GET',
//       url: current_url + '/api-admin/Product/get-all',
//     }).then(function (response) {
//       debugger;
//       $scope.sanpham = response.data;
//     });
//   };
//   $scope.GetSanPham();
// });