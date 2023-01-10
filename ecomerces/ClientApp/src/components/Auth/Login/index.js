import {MdOutlineLogin} from "react-icons/md";
import * as yup from "yup";
import {SubmitHandler, useForm} from "react-hook-form";
import {yupResolver} from '@hookform/resolvers/yup';
import axios from "axios";
import Swal from "sweetalert2";
import {useEffect} from "react";

const schema = yup.object().shape({
    email: yup.string().email().required(),
    password: yup.string().required()
});
const Login = () => {
    const {register, handleSubmit, formState: {errors}} = useForm({
        resolver: yupResolver(schema)
    });
    useEffect(() => {
        if (localStorage.getItem('UserName')) {
            window.location.href = "/";
        }
    }, []);
    const SubmitHandler = (data) => {
        axios({
            method: 'post',
            url: `https://localhost:7087/Login`,
            data: data,
            headers: {'Content-Type': 'application/json'}
        }).then((response) => {
            console.log(response);
            if (response.status === 200) {
                localStorage.setItem('UserId', response.data.id);
                localStorage.setItem('UserName', response.data.name);
                Swal.fire(
                    'Good job!',
                    'Login success!',
                    'success'
                ).then(r => {
                    return window.location.href = "/";
                })
            }
        }, (error) => {
            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: 'Invalid email or password!',
            }).then(r => {
                console.log(r);
            })
        });
    }
    return (
        <div className={'bg-[#F5F5F5] mt-4'}>
            <div className={'container mx-auto w-full flex items-center justify-center py-20'}>
                <div className={'shadow bg-white p-6'}>
                    <h3 className={'text-center text-2xl font-bold'}>Đăng nhập</h3>
                    <form onSubmit={handleSubmit(SubmitHandler)} className={'w-[400px]'}>
                        <div className="email mb-4">
                            <label htmlFor="email">Email</label>
                            <input {...register('email')} type="email" className={'form-control outline-none mt-2'}/>
                            {errors.email && <p className={'text-red-500 text-sm'}>{errors.email.message}</p>}
                        </div>
                        <div className="password mb-4">
                            <label htmlFor="password">Mật khẩu</label>
                            <input {...register('password')} type="password"
                                   className={'form-control outline-none mt-2'}/>
                            {errors.password && <p className={'text-red-500 text-sm'}>{errors.password.message}</p>}
                        </div>
                        <div className={'mt-4'}>
                            <button type={"submit"}
                                    className={'bg-[#f57224] text-white p-2 flex items-center justify-center gap-2 rounded w-full hover:opacity-80 transition'}>
                                <MdOutlineLogin/> <span>Đăng nhập</span>
                            </button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    )
}

export default Login