using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Repository
{
   public interface IProductRepository
    {
        bool CreateProduct(Product product);
        bool CreateProduct1(Product product);
        List<Product> GetAllProduct();
        bool DeleteProduct(int id);
        bool UpdateProduct(Product product);

        List<Product> SearchForProduct(Product product);

        List<Product> SearchForProductByStartAndEndDate(Product product);

        List<Product> GetAllAuctionAndProduct();
        CountproductDTO Countproduct();
        GetProductByIdDTO GetProductById(GetProductByIdDTO getProduct);
        List<GetProductUserIdDTO> GetProductUserId(GetProductUserIdDTO pro);
       bool ApprovalSell(ApprovalSellDTO product);
        List<GetCartByUserIdDTO> GetCartByUserId(GetCartByUserIdDTO pro);
        List<PurchasesInfoDTO> GetOrderbyUserID(PurchasesInfoDTO pro1);



        }
}
