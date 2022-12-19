using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using FinalProject.Auction.Core.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Auction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;
        public static IWebHostEnvironment _webHostEnvironment;


        public ProductController(IProductService productService, IWebHostEnvironment webHostEnvironment)
        {
            _productService = productService;
            _webHostEnvironment = webHostEnvironment;

        }



        [HttpGet]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]

        public List<Product> GetAllProduct()
        {
            return _productService.GetAllProduct();
        }


        [HttpPost]
        [Route("CreateProduct")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateProduct(Product product)
        {

           
          
         
            return _productService.CreateProduct(product);



        }


        [HttpPost]
        [Route("CreateProduct1")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateProduct1( Product product)
        {




            return _productService.CreateProduct1(product);



        }


        [HttpPut]
        [Route("UpdateProduct")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateProduct([FromForm] Product product, IFormFile Image)
        {

            var pathImage = Path.Combine(_webHostEnvironment.WebRootPath, "images", Image.FileName);
            var streamImage = new FileStream(pathImage, FileMode.Append);
            Image.CopyTo(streamImage);
            var pr = new Product
            {
                ProductId = product.ProductId,

                Title = product.Title,
                PriceProduct = product.PriceProduct,
                StartDate = product.StartDate,
                EndDate = product.EndDate,
                Image = pathImage,
                Description = product.Description,
                CategoryId = product.CategoryId,
                UserId = product.UserId,
                Status = product.Status,
            };

            _productService.UpdateProduct(pr);
            return _productService.UpdateProduct(product);
        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteProduct(int id)
        {
            return _productService.DeleteProduct(id);
        }

        [HttpPost]
        [Route("SearchForProduct")]
        [ProducesResponseType(typeof(List<>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> SearchForProduct(Product product)
        {
            return _productService.SearchForProduct(product);
        }

        [HttpPost]
        [Route("SearchForProductByStartAndEndDate")]
        [ProducesResponseType(typeof(List<>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> SearchForProductByStartAndEndDate(Product product)
        {
            return _productService.SearchForProductByStartAndEndDate(product);
        }

        [HttpGet]
        [Route("GetAllAuctionAndProduct")]
        [ProducesResponseType(typeof(List<>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> GetAllAuctionAndProduct()
        {
            return _productService.GetAllAuctionAndProduct();
        }





        [Route("uploadImage")]
        [HttpPost]
        public string UploadIMage()
        {
            try
            {
                var file = Request.Form.Files[0];//:c:/usersdkosf//c:/users/users/desktop/image.jpeg
                byte[] fileContent;
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileContent = ms.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                //decoder for image name , no duplicate errors
                string attachmentFileName = $"{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                //path for angualr project file
                var fullPath = Path.Combine("E:\\Fina lProject Auction\\angular\\Auction\\src\\assets\\img", attachmentFileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
        
                    file.CopyTo(stream);
                }

                return attachmentFileName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }



        [HttpGet]
        [Route("Countproduct")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public CountproductDTO Countproduct()
        {
            return _productService.Countproduct();

        }

        [HttpPost]
        [Route("GetProductById")]
        [ProducesResponseType(typeof(GetProductByIdDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public GetProductByIdDTO GetProductById(GetProductByIdDTO getProduct)
        {
            return _productService.GetProductById(getProduct);

        }
        [HttpPost]
        [Route("GetProductUserId")]
        [ProducesResponseType(typeof(GetProductUserIdDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public List<GetProductUserIdDTO> GetProductUserId(GetProductUserIdDTO pro)
        {
            return _productService.GetProductUserId(pro);
        }

        [HttpPost]
        [Route("ApprovalSell")]
        [ProducesResponseType(typeof(ApprovalSellDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public bool ApprovalSell(ApprovalSellDTO product)
        {
            return _productService.ApprovalSell(product);
        }

        [HttpPost]
        [Route("GetCartByUserId")]
        [ProducesResponseType(typeof(GetCartByUserIdDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetCartByUserIdDTO> GetCartByUserId(GetCartByUserIdDTO pro)
        {
            return _productService.GetCartByUserId(pro);
        }
        [HttpPost]
        [Route("GetOrderbyUserID")]
        [ProducesResponseType(typeof(PurchasesInfoDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<PurchasesInfoDTO> GetOrderbyUserID(PurchasesInfoDTO pro1)
        {
            return _productService.GetOrderbyUserID(pro1);
        }

    }
}
