using EasyCashIdentityPrject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserrValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username Alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password Alanı boş geçilemez");
            RuleFor(x => x.Confirmpassword).NotEmpty().WithMessage("Confirmpassword Alanı boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriniz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter  veri girişi yapınız");
            RuleFor(x => x.Confirmpassword).Equal(y => y.Password).WithMessage("Parolanız eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir email girişi yapınız");
        }
    }
}
