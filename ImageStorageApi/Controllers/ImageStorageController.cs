using ImageDatabse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ImageStorageApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ImageStorageController(ImageContext imageContext) : ControllerBase
    {
        [HttpPost("AddImage")]
        public async Task<ActionResult> AddImageBase64([FromBody] ImageDTO imageDTO)
        {
            if (imageDTO == null)
                return BadRequest();

            Image image = new Image() { Base64 = imageDTO.Data };
            imageContext.Images.Add(image);
            await imageContext.SaveChangesAsync();
            return Ok(image);
        }

        [HttpGet("GetAllImages")]
        public async Task<List<Image>> GetAllImage()
        {
            return imageContext.Images.ToList();
        }
    }
}
