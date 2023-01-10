import Slider from "react-slick";

const SliderHome = () => {
    const settings = {
        dots: false,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
    };
    return (
        <div className={'mt-4'}>
            <Slider {...settings}>
                <div>
                    <img className={'w-full'} src="https://icms-image.slatic.net/images/ims-web/322b9c22-1f70-4c92-a948-b7a30f336627.jpg" alt=""/>
                </div>
                <div>
                    <img className={'w-full'} src="https://lzd-img-global.slatic.net/g/icms/images/ims-web/cdbadd2b-5d56-4352-b861-c1fb5c62a561.jpg_1200x1200q90.jpg_.webp" alt=""/>
                </div>
                <div>
                    <img className={'w-full'} src="https://lzd-img-global.slatic.net/g/icms/images/ims-web/fe2c0971-ff54-41b1-8f40-18bf3850ea48.jpg_1200x1200q90.jpg_.webp" alt=""/>
                </div>
            </Slider>
        </div>
    )
}

export default SliderHome;