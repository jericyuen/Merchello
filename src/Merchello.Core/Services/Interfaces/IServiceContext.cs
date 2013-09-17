﻿using System;
using Merchello.Core.Persistence;
using Umbraco.Core.Persistence.UnitOfWork;

namespace Merchello.Core.Services
{
    /// <summary>
    /// Defines the ServiceContext, which provides access to the following services:
    /// <see cref="ICustomerService"/>
    /// </summary>
    public interface IServiceContext
    {

        IAddressService AddressService { get; }

        /// <summary>
        /// Gets the <see cref="ICustomerService"/>
        /// </summary>
        ICustomerService CustomerService { get; }

        /// <summary>
        /// Gets the <see cref="BasketService"/>
        /// </summary>
        IBasketService BasketService { get; }

        /// <summary>
        /// Gets the <see cref="IInvoiceService"/>
        /// </summary>
        IInvoiceService InvoiceService { get; }

        /// <summary>
        /// Gets the <see cref="IPaymentService"/>
        /// </summary>
        IPaymentService PaymentService { get; }
    }
    
}
