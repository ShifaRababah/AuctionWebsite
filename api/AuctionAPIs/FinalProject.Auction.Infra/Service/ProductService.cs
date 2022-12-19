using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Infra.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool CreateProduct(Product product)
        {
           return _productRepository.CreateProduct(product);
        }
        public bool CreateProduct1(Product product)
        {
            return _productRepository.CreateProduct1(product);
        }
        public bool DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public List<Product> GetAllProduct()
        {
            return _productRepository.GetAllProduct();
        }

        public bool UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }

        public List<Product> SearchForProduct(Product product)
        {
            return _productRepository.SearchForProduct(product);
        }

        public List<Product> SearchForProductByStartAndEndDate(Product product)
        {
            return _productRepository.SearchForProductByStartAndEndDate(product);
        }

        public List<Product> GetAllAuctionAndProduct()
        {
            return _productRepository.GetAllAuctionAndProduct();
        }

        public CountproductDTO Countproduct()
        {
            return _productRepository.Countproduct();
        }
        public GetProductByIdDTO GetProductById(GetProductByIdDTO getProduct)
        {
            return _productRepository.GetProductById(getProduct);
        }

        public List<GetProductUserIdDTO> GetProductUserId(GetProductUserIdDTO pro)
        {
            return _productRepository.GetProductUserId(pro);
        }

        public bool ApprovalSell(ApprovalSellDTO product)
        {
            return _productRepository.ApprovalSell(product);
        }
        public List<GetCartByUserIdDTO> GetCartByUserId(GetCartByUserIdDTO pro)
        {
            return _productRepository.GetCartByUserId(pro);
        }
        public List<PurchasesInfoDTO> GetOrderbyUserID(PurchasesInfoDTO pro1)
        {
            return _productRepository.GetOrderbyUserID(pro1);
        }




        }
}
